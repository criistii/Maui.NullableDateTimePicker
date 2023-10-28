﻿using Maui.NullableDateTimePicker.Enums;
using Maui.NullableDateTimePicker.Interfaces;

namespace Maui.NullableDateTimePicker.Models
{
    public class NullableDateTimePickerOptions : INullableDateTimePickerOptions
    {
        public DateTime? InitDateTimeValue { get; set; }
        public PickerMode PickerMode { get; set; } = PickerMode.Date;
        public DateTime? MinDate { get; set; } 
        public DateTime? MaxDate { get; set; } 
        public string OkButtonText { get; set; } = "OK";
        public string CancelButtonText { get; set; } = "Cancel";
        public string ClearButtonText { get; set; } = "Clear";
        public Color BackgroundColor { get; set; }
        public Color ForeColor { get; set; }
        public Color HeaderForeColor { get; set; }
        public Color HeaderBackgroundColor { get; set; }
        public Style ToolButtonsStyle { get; set; }
        public Style DayStyle { get; set; }
        public Style OtherMonthDayStyle { get; set; } 
        public Style SelectedDayStyle { get; set; } 
        public Style DayNamesStyle { get; set; } 
        public bool ShowWeekNumbers { get; set; } 
        public Style WeekNumberStyle { get; set; }
        public bool ShowOtherMonthDays { get; set; } = true;
        public Color ActivityIndicatorColor { get; set; }
        public bool ShowClearButton { get; set; } 
        public bool CloseOnOutsideClick { get; set; } 
    }
}