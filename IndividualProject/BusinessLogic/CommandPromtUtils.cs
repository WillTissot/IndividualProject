using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IndividualProject.BusinessLogic
{
    class CommandPromtUtils
    {
        //-----------------------------------------------------------------------TRAINERS ----------------------------------------------------------------------
        public Trainer GetTrainerDetails(List<string> subjects = null)
        {
            if (subjects == null)
            {
                subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            }
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Please enter the first name: "); // I could create an extra method to pass on the string questions
            trainer.LastName = AskDetail("Please enter the last name: ");
            trainer.Subject = AskDetail("Select the subject he/she teaches: ", subjects);
            return (trainer);
        }
        private string AskDetail(string message, List<string> subjects = null) //asking trainer details!
        {
            string result;
            Console.Write(message);
            if (subjects != null)
            {
                result = SelectFromListOfStrings(subjects);
            }
            else
            {
                result = Console.ReadLine();
            }
            return (result);
        }
        //-----------------------------------------------------------------------Generalized selection from list-------------------------------------------------
        private string SelectFromListOfStrings(List<string> elements) 
        {
            Console.WriteLine();
            int counter = 1;
            int choice;
            foreach (var item in elements)
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            do                                      
            {
                choice = Convert.ToInt32(Console.ReadLine()); //perhaps i should print a message if wrong entry!!!!
            } while (!(1 <= choice && choice <= elements.Count));
            return (elements.ElementAt(choice - 1)); // or elements[choice - 1]
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public void PrintTrainerList (List<Trainer> trainers) 
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }
        //-----------------------------------------------------------------------COURSE--------------------------------------------------------------------------
        
        //-----------------------------------------------------------------------ASSIGNMENT----------------------------------------------------------------------

        //-----------------------------------------------------------------------STUDENT-------------------------------------------------------------------------
    }
}
