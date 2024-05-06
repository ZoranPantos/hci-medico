using Caliburn.Micro;
using HciMedico.Domain.Models.DisplayModels;

namespace HciMedico.App.ViewModels.Shared;

public class ScheduleViewModel : Conductor<object>
{
    private readonly int _weekLength = 7;
    private readonly int _weeksToShow = 5;
    private DateTime _displayedMonthYear = DateTime.Now;

    private BindableCollection<ScheduleCellDisplayModel> _scheduleCellDisplayModels = [];
    public BindableCollection<ScheduleCellDisplayModel> ScheduleCellDisplayModels
    {
        get => _scheduleCellDisplayModels;
        set
        {
            _scheduleCellDisplayModels = value;
            NotifyOfPropertyChange(() => ScheduleCellDisplayModels);
        }
    }

    private string _displayedMonthYearString = DateTime.Now.ToString("MMMM yyyy");
    public string DisplayedMonthYearString
    {
        get => _displayedMonthYearString;
        set
        {
            _displayedMonthYearString = value;
            NotifyOfPropertyChange(() => DisplayedMonthYearString);
        }
    }

    public ScheduleViewModel()
    {
        InitializeCalendar();
        InitializeShifts();
    }

    private void InitializeCalendar()
    {
        try
        {
            int cellsCount = _weeksToShow * _weekLength;
            ScheduleCellDisplayModels = [];

            for (int i = 0; i < cellsCount; i++)
            {
                ScheduleCellDisplayModels.Add(new());
            }

            var firstDayOfMonth = new DateTime(_displayedMonthYear.Year, _displayedMonthYear.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(_displayedMonthYear.Year, _displayedMonthYear.Month);

            var firstDayOfWeek = firstDayOfMonth.DayOfWeek;
            int firstDayOfWeekIndex = (int)firstDayOfWeek - 1;

            //Initialize first day in current month
            ScheduleCellDisplayModels[firstDayOfWeekIndex].IsSelectedMonth = true;
            ScheduleCellDisplayModels[firstDayOfWeekIndex].DateTime = firstDayOfMonth;

            //Initialize days from previous month
            var firstDayOfMonthTmp = firstDayOfMonth;
            for (int i = firstDayOfWeekIndex - 1; i >= 0; i--)
            {
                firstDayOfMonthTmp = firstDayOfMonthTmp.AddDays(-1);
                ScheduleCellDisplayModels[i].DateTime = firstDayOfMonthTmp;
                ScheduleCellDisplayModels[i].IsSelectedMonth = false;
            }

            //Initialize following days from current and next month
            var firstDayOfMonthTmp2 = firstDayOfMonth;
            for (int i = firstDayOfWeekIndex + 1; i < cellsCount; i++)
            {
                firstDayOfMonthTmp2 = firstDayOfMonthTmp2.AddDays(1);
                ScheduleCellDisplayModels[i].DateTime = firstDayOfMonthTmp2;
                ScheduleCellDisplayModels[i].IsSelectedMonth = i <= daysInMonth + firstDayOfWeekIndex - 1;

                //Check for today
                if (DateTime.Now.Date == firstDayOfMonthTmp2.Date)
                {
                    ScheduleCellDisplayModels[i].IsToday = true;
                }
            }
        }
        catch (Exception ex)
        {

        }
    }

    private void InitializeShifts()
    {
        var scheduleCells = UserContext.CurrentUser?.Employee?.Schedule.ScheduleCells;

        if (scheduleCells is null) return;

        int cellsCount = ScheduleCellDisplayModels.Count;

        foreach (var cell in scheduleCells)
        {
            //TODO: Refactor and improve this
            for (int i = 0; i < cellsCount; i++)
            {
                if (ScheduleCellDisplayModels[i].DateTime.Date == cell.DateTime.Date)
                {
                    ScheduleCellDisplayModels[i].ShiftStartTime = cell.ShiftStartTime;
                    ScheduleCellDisplayModels[i].ShiftEndTime = cell.ShiftEndTime;
                }
            }
        }
    }

    public void NextMonth()
    {
        _displayedMonthYear = _displayedMonthYear.AddMonths(1);
        DisplayedMonthYearString = _displayedMonthYear.ToString("MMMM yyyy");

        InitializeCalendar();
        InitializeShifts();
    }

    public void PreviousMonth()
    {
        _displayedMonthYear = _displayedMonthYear.AddMonths(-1);
        DisplayedMonthYearString = _displayedMonthYear.ToString("MMMM yyyy");

        InitializeCalendar();
        InitializeShifts();
    }
}
