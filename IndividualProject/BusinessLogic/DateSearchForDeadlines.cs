using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class DateSearchForDeadlines
    {
        public void GetDeadlines(List<SchoolClass> schoolClasses)
        {
            Console.WriteLine("Please enter a date to search for the deadlines that week: ");
            DateTime entriedDate = Convert.ToDateTime(Console.ReadLine());

            DateTime startDate;
            DateTime endDate;
            if (entriedDate.DayOfWeek == DayOfWeek.Monday)
            {
                startDate = entriedDate;
                endDate = entriedDate.AddDays(6);
            }
            else if (entriedDate.DayOfWeek == DayOfWeek.Tuesday)
            {
                startDate = entriedDate.AddDays(-1);
                endDate = entriedDate.AddDays(5);
            }
            else if (entriedDate.DayOfWeek == DayOfWeek.Wednesday)
            {
                startDate = entriedDate.AddDays(-2);
                endDate = entriedDate.AddDays(4);
            }
            else if (entriedDate.DayOfWeek == DayOfWeek.Wednesday)
            {
                startDate = entriedDate.AddDays(-2);
                endDate = entriedDate.AddDays(4);
            }
            else if (entriedDate.DayOfWeek == DayOfWeek.Thursday)
            {
                startDate = entriedDate.AddDays(-3);
                endDate = entriedDate.AddDays(3);
            }
            else if (entriedDate.DayOfWeek == DayOfWeek.Friday)
            {
                startDate = entriedDate.AddDays(-4);
                endDate = entriedDate.AddDays(2);
            }
            else if (entriedDate.DayOfWeek == DayOfWeek.Saturday)
            {
                startDate = entriedDate.AddDays(-5);
                endDate = entriedDate.AddDays(1);
            }
            else
            {
                startDate = entriedDate.AddDays(-6);
                endDate = entriedDate;
            }

            Console.WriteLine($"During {startDate.ToShortDateString()} - {endDate.ToShortDateString()} : ");
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                for (int j = 0; j < schoolClasses[i].Assignment.Count; j++)
                {
                    if (startDate <= schoolClasses[i].Assignment[j].SubDateTime && schoolClasses[i].Assignment[j].SubDateTime<= endDate)
                    {
                        Console.WriteLine($"The assignment is {schoolClasses[i].Assignment[j]} and with these students: ");
                        foreach (var item in schoolClasses[i].Students)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }
        
    }
}
