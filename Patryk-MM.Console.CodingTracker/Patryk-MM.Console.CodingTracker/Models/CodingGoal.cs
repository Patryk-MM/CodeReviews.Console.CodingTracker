﻿namespace Patryk_MM.Console.CodingTracker.Models {
    public class CodingGoal {
        public int Id { get; }
        public DateTime YearAndMonth => new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public int Hours { get; set; }
        public int HourGoal => Hours * 3600;
    }
}
