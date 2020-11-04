using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTrainersInfo(); //Main should only has one line!
        }

        static void GetTrainersInfo ()
        {
            CommandPromtUtils cpUtils = new CommandPromtUtils(); // It must be transerred to a new class!!!!!!
            List<Trainer> trainers = new List<Trainer>();
            Console.WriteLine("-- Recording process for trainers --");
            do
            {
                trainers.Add(cpUtils.GetTrainerDetails());
                Console.WriteLine("Press ESCAPE to exit trainer's register process or any key to continue recording: ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            cpUtils.PrintTrainerList(trainers);
        }
        static void GetAssignmentsInfor()
        {
            CommandPromtUtils cpUtils = new CommandPromtUtils();

        }
    }
}
