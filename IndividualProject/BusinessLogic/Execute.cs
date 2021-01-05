using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class Execute
    {
        public Execute()
        {
            Start();
        }

        private void Start()
        {
            Console.WriteLine("Would you like to enter date for schoolclasses? (Y/N) ");
            string temp = Console.ReadLine();
            if (temp == "Y")
                StartWithUserInput();
            else
                PrintExamples();
        }
        private void StartWithUserInput()
        {
            DataEntry class1 = new DataEntry();
            class1.GetSchoolClasses();
        }
        private void PrintExamples()
        {
            SyntheticData syntheticData = new SyntheticData();
        }
    }
}
