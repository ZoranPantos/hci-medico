using Caliburn.Micro;
using HciMedico.Domain.Models.DisplayModels;

namespace HciMedico.App.ViewModels.Shared;

public class ScheduleViewModel : Conductor<object>
{
    private readonly int _weekLength = 7;
    private readonly int _weeksToShow = 5;
    private DateTime _displayedMonthYear = DateTime.Now;

    private ScheduleDisplayModel _scheduleDisplayModel = new();
    public ScheduleDisplayModel ScheduleDisplayModel
    {
        get => _scheduleDisplayModel;
        set
        {
            _scheduleDisplayModel = value;
            NotifyOfPropertyChange(() => ScheduleDisplayModel);
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
        AddTestPlaceholders();
        InitializeShifts();
    }

    private void InitializeCalendar()
    {
        try
        {
            ScheduleDisplayModel = new() { ScheduleCellDisplayModels = new ScheduleCellDisplayModel[_weeksToShow * _weekLength] };

            int shiftsCount = ScheduleDisplayModel.ScheduleCellDisplayModels.Length;

            for (int i = 0; i < shiftsCount; i++)
            {
                ScheduleDisplayModel.ScheduleCellDisplayModels[i] = new();
            }

            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            var firstDayOfWeek = firstDayOfMonth.DayOfWeek;
            int firstDayOfWeekIndex = (int)firstDayOfWeek - 1;

            //Initialize first day in current month
            ScheduleDisplayModel.ScheduleCellDisplayModels[firstDayOfWeekIndex].IsSelectedMonth = true;
            ScheduleDisplayModel.ScheduleCellDisplayModels[firstDayOfWeekIndex].DateTime = firstDayOfMonth;
            //ScheduleDisplayModel.ScheduleCellDisplayModels[firstDayOfWeekIndex].ShiftStartTime = "[curr month]";

            //Initialize days from previous month
            var firstDayOfMonthTmp = firstDayOfMonth;
            for (int i = firstDayOfWeekIndex - 1; i >= 0; i--)
            {
                firstDayOfMonthTmp = firstDayOfMonthTmp.AddDays(-1);
                ScheduleDisplayModel.ScheduleCellDisplayModels[i].DateTime = firstDayOfMonthTmp;
                ScheduleDisplayModel.ScheduleCellDisplayModels[i].IsSelectedMonth = false;
            }

            //Initialize following days from current and next month
            var firstDayOfMonthTmp2 = firstDayOfMonth;
            for (int i = firstDayOfWeekIndex + 1; i < shiftsCount; i++)
            {
                firstDayOfMonthTmp2 = firstDayOfMonthTmp2.AddDays(1);
                ScheduleDisplayModel.ScheduleCellDisplayModels[i].DateTime = firstDayOfMonthTmp2;
                //ScheduleDisplayModel.ScheduleCellDisplayModels[i].IsCurrentMonth = i <= daysInMonth - 1;
                ScheduleDisplayModel.ScheduleCellDisplayModels[i].IsSelectedMonth = i <= daysInMonth + firstDayOfWeekIndex - 1;
                //ScheduleDisplayModel.ScheduleCellDisplayModels[i].ShiftStartTime = i <= daysInMonth + firstDayOfWeekIndex - 1 ? "[curr month]" : "";

                //Check for today
                if (DateTime.Now.Date == firstDayOfMonthTmp2.Date)
                {
                    ScheduleDisplayModel.ScheduleCellDisplayModels[i].IsToday = true;
                    //ScheduleDisplayModel.ScheduleCellDisplayModels[i].ShiftStartTime = "[TODAY]";
                }
            }

            #region TmpComment
            //Schedule = new() { ScheduleCells = new ScheduleCell[_weeksToShow * _weekLength] };

            //for (int i = 0; i < Schedule.ScheduleCells.Length; i++)
            //    Schedule.ScheduleCells[i] = new();

            //var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            //var firstDayOfWeek = firstDayOfMonth.DayOfWeek;
            //int firstDayOfWeekIndex = (int)firstDayOfWeek - 1;

            ////Initialize first day in current month
            //Schedule.ScheduleCells[firstDayOfWeekIndex].IsCurrentMonth = true;
            //Schedule.ScheduleCells[firstDayOfWeekIndex].DateTime = firstDayOfMonth;
            //Schedule.ScheduleCells[firstDayOfWeekIndex].ShiftStartTime = "*";

            ////Initialize days from previous month
            //var firstDayOfMonthTmp = firstDayOfMonth;
            //for (int i = firstDayOfWeekIndex - 1; i >= 0; i--)
            //{
            //    firstDayOfMonthTmp = firstDayOfMonthTmp.AddDays(-1);
            //    Schedule.ScheduleCells[i].DateTime = firstDayOfMonthTmp;
            //    Schedule.ScheduleCells[i].IsCurrentMonth = false;
            //}

            ////Initialize following days from current and next month
            //var firstDayOfMonthTmp2 = firstDayOfMonth;
            //for (int i = firstDayOfWeekIndex + 1; i < Schedule.ScheduleCells.Length; i++)
            //{
            //    firstDayOfMonthTmp2 = firstDayOfMonthTmp2.AddDays(1);
            //    Schedule.ScheduleCells[i].DateTime = firstDayOfMonthTmp2;
            //    Schedule.ScheduleCells[i].IsCurrentMonth = i <= daysInMonth - 1;
            //    Schedule.ScheduleCells[i].ShiftStartTime = i <= daysInMonth + firstDayOfWeekIndex - 1 ? "*" : "";

            //    //Check for today
            //    if (DateTime.Now.Date == firstDayOfMonthTmp2.Date)
            //    {
            //        Schedule.ScheduleCells[i].IsToday = true;
            //        Schedule.ScheduleCells[i].ShiftStartTime = "TODAY";
            //    }
            //}
            #endregion
        }
        catch (Exception ex)
        {

        }
    }

    private void InitializeShifts()
    {
        var scheduleCells = UserContext.CurrentUser?.Employee?.Schedule.ScheduleCells;

        if (scheduleCells is null) return;

        int shiftsCount = ScheduleDisplayModel.ScheduleCellDisplayModels.Length;

        foreach (var cell in scheduleCells)
        {
            //TODO: Refactor and improve this
            for (int i = 0; i < shiftsCount; i++)
            {
                if (ScheduleDisplayModel.ScheduleCellDisplayModels[i].DateTime.Date == cell.DateTime.Date)
                {
                    //TODO: Replace += with = after testing
                    ScheduleDisplayModel.ScheduleCellDisplayModels[i].ShiftStartTime += cell.ShiftStartTime;
                    ScheduleDisplayModel.ScheduleCellDisplayModels[i].ShiftEndTime = cell.ShiftEndTime;
                }
            }
        }
    }

    //Tmp Test method
    private void AddTestPlaceholders()
    {
        for (int i = 0; i < ScheduleDisplayModel.ScheduleCellDisplayModels.Length; i++)
        {
            if (ScheduleDisplayModel.ScheduleCellDisplayModels[i].IsSelectedMonth)
            {
                ScheduleDisplayModel.ScheduleCellDisplayModels[i].ShiftStartTime +=
                    ScheduleDisplayModel.ScheduleCellDisplayModels[i].IsToday ? "TODAY" : "***";
            }
        }
    }

    private void InitializeNextMonth()
    {

    }

    private void InitializePreviousMonth()
    {

    }

    public void NextMonth()
    {
        _displayedMonthYear = _displayedMonthYear.AddMonths(1);
        DisplayedMonthYearString = _displayedMonthYear.ToString("MMMM yyyy");
    }

    public void PreviousMonth()
    {
        _displayedMonthYear = _displayedMonthYear.AddMonths(-1);
        DisplayedMonthYearString = _displayedMonthYear.ToString("MMMM yyyy");
    }
}
