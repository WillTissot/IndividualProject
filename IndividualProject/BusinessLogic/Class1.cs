using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject.BusinessLogic
{
    class Class1
    {
        public void Maria()
        {
            CommandPromtUtils utils = new CommandPromtUtils();
            SchoolClass schooClass = new SchoolClass();

            Console.WriteLine("---- Starting Recording Process ----");

            schooClass.Course     = utils.GetCourseInfo();
            schooClass.Trainer    = utils.GetTrainers(schooClass.Course.Title);
            schooClass.Assignment = utils.GetAssignments();
            schooClass.Students   = utils.GetStudents();
            Console.WriteLine(schooClass);


        }
    }
}
