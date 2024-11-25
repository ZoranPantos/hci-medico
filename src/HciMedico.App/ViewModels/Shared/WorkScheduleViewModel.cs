﻿using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.Domain.Models.DisplayModels;

namespace HciMedico.App.ViewModels.Shared;

public class WorkScheduleViewModel : Conductor<object>
{
    private readonly int _weekLength = 7;
    public int WeekLength => _weekLength;

    private readonly int _weeksToShow = 6;
    public int WeeksToShow => _weeksToShow;

    private DateTime _displayedMonthYear = DateTime.Now.Date;

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

    private int _completedShiftsMonth;
    public int CompletedShiftsMonth
    {
        get => _completedShiftsMonth;
        set
        {
            _completedShiftsMonth = value;
            NotifyOfPropertyChange(() => CompletedShiftsMonth);
        }
    }

    private int _completedShiftsYear;
    public int CompletedShiftsYear
    {
        get => _completedShiftsYear;
        set
        {
            _completedShiftsYear = value;
            NotifyOfPropertyChange(() => CompletedShiftsYear);
        }
    }

    public WorkScheduleViewModel()
    {
        InitializeCalendar();
        InitializeShifts();
        CalculateCompletedShifts();
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

            // Note: DayOfWeek.Sunday has index value of 0 in enum
            var firstDayOfWeek = firstDayOfMonth.DayOfWeek;
            int firstDayOfWeekIndex = firstDayOfWeek.Equals(DayOfWeek.Sunday) ? 6 : (int)firstDayOfWeek - 1;

            // Initialize first day in current month
            ScheduleCellDisplayModels[firstDayOfWeekIndex].IsSelectedMonth = true;
            ScheduleCellDisplayModels[firstDayOfWeekIndex].DateTime = firstDayOfMonth;

            // Initialize days from previous month
            var firstDayOfMonthTmp = firstDayOfMonth;
            for (int i = firstDayOfWeekIndex - 1; i >= 0; i--)
            {
                firstDayOfMonthTmp = firstDayOfMonthTmp.AddDays(-1);
                ScheduleCellDisplayModels[i].DateTime = firstDayOfMonthTmp;
                ScheduleCellDisplayModels[i].IsSelectedMonth = false;
            }

            // Initialize following days from current and next month
            var firstDayOfMonthTmp2 = firstDayOfMonth;
            for (int i = firstDayOfWeekIndex + 1; i < cellsCount; i++)
            {
                firstDayOfMonthTmp2 = firstDayOfMonthTmp2.AddDays(1);
                ScheduleCellDisplayModels[i].DateTime = firstDayOfMonthTmp2;
                ScheduleCellDisplayModels[i].IsSelectedMonth = i <= daysInMonth + firstDayOfWeekIndex - 1;

                // Check for today
                if (DateTime.Now.Date == firstDayOfMonthTmp2.Date)
                {
                    ScheduleCellDisplayModels[i].IsToday = true;
                }
            }
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(WorkScheduleViewModel)}.{nameof(InitializeCalendar)}";
            throw new MedicoException(message, ex);
        }
    }

    private void InitializeShifts()
    {
        var scheduleCells = UserContext.CurrentUser?.Employee?.WorkSchedule.WorkShifts;

        if (scheduleCells is null) return;

        int cellsCount = ScheduleCellDisplayModels.Count;

        foreach (var cell in scheduleCells)
        {
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

    private void CalculateCompletedShifts()
    {
        var scheduleCells = UserContext.CurrentUser?.Employee?.WorkSchedule.WorkShifts;

        if (scheduleCells is null) return;

        int completedShiftsYear = 0;
        int completedShiftsMonth = 0;

        var firstDayOfSelectedMonth = new DateTime(_displayedMonthYear.Year, _displayedMonthYear.Month, 1);
        var firstDayOfFollowingMonth = new DateTime(_displayedMonthYear.Year, _displayedMonthYear.AddMonths(1).Month, 1);

        var firstDayOfSelectedYear = new DateTime(_displayedMonthYear.Year, 1, 1);
        var firstDayOfFollowingYear = new DateTime(_displayedMonthYear.AddYears(1).Year, 1, 1);

        var today = DateTime.Today;

        while (firstDayOfSelectedYear.CompareTo(firstDayOfFollowingYear) < 0 && firstDayOfSelectedYear.CompareTo(today) < 0)
        {
            if (scheduleCells.Any(cell => cell.DateTime == firstDayOfSelectedYear && !string.IsNullOrEmpty(cell.ShiftEndTime)))
            {
                completedShiftsYear++;
            }

            if (firstDayOfSelectedYear.CompareTo(firstDayOfSelectedMonth) >= 0 && firstDayOfSelectedYear.CompareTo(firstDayOfFollowingMonth) < 0)
            {
                if (scheduleCells.Any(cell => cell.DateTime == firstDayOfSelectedYear && !string.IsNullOrEmpty(cell.ShiftEndTime)))
                    completedShiftsMonth++;
            }

            firstDayOfSelectedYear = firstDayOfSelectedYear.AddDays(1);
        }

        CompletedShiftsYear = completedShiftsYear;
        CompletedShiftsMonth = completedShiftsMonth;
    }

    public void NextMonth()
    {
        _displayedMonthYear = _displayedMonthYear.AddMonths(1);
        DisplayedMonthYearString = _displayedMonthYear.ToString("MMMM yyyy");

        InitializeCalendar();
        InitializeShifts();
        CalculateCompletedShifts();
    }

    public void PreviousMonth()
    {
        _displayedMonthYear = _displayedMonthYear.AddMonths(-1);
        DisplayedMonthYearString = _displayedMonthYear.ToString("MMMM yyyy");

        InitializeCalendar();
        InitializeShifts();
        CalculateCompletedShifts();
    }
}
