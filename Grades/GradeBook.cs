﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        internal GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AvarageGrade = sum / grades.Count;
            return stats;
        }

        public string Name;

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        private List<float> grades; 
    }
}
