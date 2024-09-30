using HciMedico.App.Services.Interfaces;
using HciMedico.Domain.Models.DTOs;
using Microsoft.Win32;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace HciMedico.App.Services.Classes;

public class PdfExporter : IPdfExporter
{
    public void Export(MedicalReportExportDto dto)
    {
        var saveFileDialog = new SaveFileDialog
        {
            Filter = "PDF files (*.pdf)|*.pdf",
            Title = "Save report as PDF",
            DefaultExt = ".pdf",
            FileName = "MedicalReport.pdf"
        };

        if (saveFileDialog.ShowDialog() == true)
            GeneratePdf(saveFileDialog.FileName, dto);
    }

    private void GeneratePdf(string filePath, MedicalReportExportDto dto)
    {
        var document = new PdfDocument();
        document.Info.Title = "Medical Report";

        var page = document.AddPage();
        var gfx = XGraphics.FromPdfPage(page);

        var headerFont = new XFont("Verdana", 20, XFontStyle.Bold);
        var textFont = new XFont("Verdana", 12);
        var italicBoldFont = new XFont("Verdana", 10, XFontStyle.Bold | XFontStyle.Italic);

        // Set the maximum width for text wrapping (leave a margin)
        double maxWidth = page.Width - 100;

        // Start position for the patient info (closer to the top)
        double yPosition = 30; // Adjusted to start higher

        // Define spacing between sections
        double subtitleSpacing = 20;
        double sectionSpacing = 40;

        // Drawing additional information before the main heading
        DrawPatientInfo(ref gfx, ref yPosition, italicBoldFont, textFont, maxWidth, dto);

        // Drawing header (centered at the top)
        gfx.DrawString("Medical Report", headerFont, XBrushes.Black, new XRect(0, yPosition + 20, page.Width, 50), XStringFormats.TopCenter);

        // Adjust the yPosition for the header, space before next section
        yPosition += 60;

        // Add spacing before the next section
        yPosition += 10; // Space between "Medical Report" and the first section

        // Draw each section (with pagination)
        DrawSection(ref page, ref gfx, ref yPosition, maxWidth, subtitleSpacing, sectionSpacing, "Analysis:", dto.Analysis, document);
        DrawSection(ref page, ref gfx, ref yPosition, maxWidth, subtitleSpacing, sectionSpacing, "Previous Findings:", dto.PreviousFindings, document);
        DrawSection(ref page, ref gfx, ref yPosition, maxWidth, subtitleSpacing, sectionSpacing, "Diagnosis:", dto.Diagnosis, document);
        DrawSection(ref page, ref gfx, ref yPosition, maxWidth, subtitleSpacing, sectionSpacing, "Therapy:", dto.Therapy, document);
        DrawSection(ref page, ref gfx, ref yPosition, maxWidth, subtitleSpacing, sectionSpacing, "Additional Notes:", dto.AdditionalNotes, document);

        document.Save(filePath);
    }

    private void DrawPatientInfo(ref XGraphics gfx, ref double yPosition, XFont italicBoldFont, XFont textFont, double maxWidth, MedicalReportExportDto dto)
    {
        gfx.DrawString("Medico", italicBoldFont, XBrushes.Black, new XRect(40, yPosition, maxWidth, 20), XStringFormats.TopLeft);
        yPosition += 20;

        gfx.DrawString($"Patient name: {dto.PatientFullName}", textFont, XBrushes.Black, new XRect(40, yPosition, maxWidth, 20), XStringFormats.TopLeft);
        yPosition += 20;

        gfx.DrawString($"Patient UID: {dto.PatientUid}", textFont, XBrushes.Black, new XRect(40, yPosition, maxWidth, 20), XStringFormats.TopLeft);
        yPosition += 20;

        gfx.DrawString($"Appointed doctor: {dto.DoctorFullName}", textFont, XBrushes.Black, new XRect(40, yPosition, maxWidth, 20), XStringFormats.TopLeft);
        yPosition += 20;
    }

    private void DrawSection(
        ref PdfPage page,
        ref XGraphics gfx,
        ref double yPosition,
        double maxWidth,
        double subtitleSpacing,
        double sectionSpacing,
        string title,
        string content,
        PdfDocument document)
    {
        // Check if new content fits on the current page
        CheckNewPage(ref page, ref gfx, ref yPosition, subtitleSpacing, document);

        // Draw subtitle (e.g., Analysis:)
        gfx.DrawString(title, new XFont("Verdana", 12, XFontStyle.Underline), XBrushes.Black, new XRect(40, yPosition, maxWidth, subtitleSpacing), XStringFormats.TopLeft);
        yPosition += subtitleSpacing;

        // Draw content with wrapping, and update the yPosition after
        yPosition = DrawTextWithWrapping(gfx, content, new XFont("Verdana", 12), 40, yPosition, maxWidth);
        yPosition += sectionSpacing;
    }

    private void CheckNewPage(ref PdfPage page, ref XGraphics gfx, ref double yPosition, double subtitleSpacing, PdfDocument document)
    {
        // Check if there's enough space for the next section
        double requiredHeight = subtitleSpacing + 50;

        // Check if there is enough space on the page
        if (yPosition + requiredHeight > page.Height - 50)
        {
            page = document.AddPage();
            gfx = XGraphics.FromPdfPage(page);
            yPosition = 50; // Reset vertical position for the new page, with a top margin
        }
    }

    private double DrawTextWithWrapping(XGraphics gfx, string text, XFont font, double x, double y, double maxWidth)
    {
        var paragraphs = text
            .Replace("\r", "")
            .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        double lineHeight = font.GetHeight() + 2; // Line height

        foreach (var paragraph in paragraphs)
        {
            var words = paragraph.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var line = string.Empty;

            foreach (var word in words)
            {
                // Check if adding this word would exceed the maxWidth
                var testLine = string.IsNullOrEmpty(line) ? word : $"{line} {word}";

                double lineWidth = gfx.MeasureString(testLine, font).Width;

                if (lineWidth > maxWidth)
                {
                    // Draw the current line and move to the next line
                    gfx.DrawString(line, font, XBrushes.Black, new XRect(x, y, maxWidth, lineHeight), XStringFormats.TopLeft);

                    line = word; // Start a new line with the current word
                    y += lineHeight; // Move down for the next line
                }
                else
                    line = testLine; // Keep adding words to the current line
            }

            // Draw any remaining text in the line for this paragraph
            if (!string.IsNullOrEmpty(line))
            {
                gfx.DrawString(line, font, XBrushes.Black, new XRect(x, y, maxWidth, lineHeight), XStringFormats.TopLeft);
                y += lineHeight; // Move down after drawing the last line of this paragraph
            }

            // Avoid adding extra space after the last paragraph
            // if not the last paragraph, add a little spacing before the next subtitle
            y += 1; // Adjust this value to set spacing between paragraphs and subtitles
        }

        return y;
    }
}
