namespace HciMedico.Domain.Models.DisplayModels;

public sealed class ScheduleCellDisplayModel
{
    public DateTime DateTime { get; set; }

    public int Day => DateTime.Day;

    public string FormattedDateString => DateTime.ToString("dd-MM-yyyy");
    public string ShiftStartTime { get; set; } = string.Empty;
    public string ShiftEndTime { get; set; } = string.Empty;

    public bool IsSelectedMonth { get; set; }
    public bool IsToday { get; set; }
}
