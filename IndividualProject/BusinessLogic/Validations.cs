using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace IndividualProject.BusinessLogic
{
    class Validations : CommandPromtUtils
    {
        //---------------------------------------------------------------------ASSIGNMENTS-----------------------------------------------------------------------
        public DateTime ValidateSubDate(DateTime startDate, DateTime endDate)
        {
            DateTime date;
            bool continueAsking;
            do
            {
                date = Convert.ToDateTime(AskDetail("Please enter submission date: (i.e. 20/03/2000)"));
                continueAsking = !(startDate < date && date < endDate);
                if (continueAsking == true)
                {
                    Console.WriteLine($"Assignment's submission date must be within course's date span! {startDate.ToShortDateString()} - {endDate.ToShortDateString()} "); // prints also the time
                }
            }
            while (continueAsking);
            return (date.Date);
        }
        public float ValidateMark(int maxMark, string nameExam)
        {
            float mark;
            do
            {
                mark = (float)Convert.ToDouble(AskDetail($"Please enter {nameExam}'s weight factor: "));
                if (!(0 <= mark && mark <= maxMark))
                {
                    Console.WriteLine($"Mark must be non negative and its max value {maxMark}/100");
                }
            }
            while (!(0 <= mark && mark <= maxMark));
            return (mark);
        }

        //---------------------------------------------------------------------STUDENTS--------------------------------------------------------------------------
        //A student must be 8 years old or older
        public DateTime ValidateBirth() 
        {
            DateTime year;
            bool continueAsking;
            do
            {
                year = (Convert.ToDateTime(AskDetail("Please enter the date of birth: ")));
                continueAsking = DateTime.Now.Year - year.Year < 8;
                if (continueAsking == true) 
                {
                    Console.WriteLine("The student must be at least 8 years old. Please enter a valid date of birth : ");
                }
            }
            while (continueAsking);
            return (year.Date);
        }
        public double ValidateFees()
        {
            double fees;
            do
            {
                fees = Convert.ToDouble(AskDetail("Please enter the tuition fees: "));
                if (fees < 0)
                {
                    Console.WriteLine("Tuition fees must be non-negative. Please enter a valid amount: ");
                }
            }
            while (fees < 0);
            return (fees);
        }
    }
}
