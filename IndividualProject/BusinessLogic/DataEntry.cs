using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject.BusinessLogic
{
    class DataEntry 
    {
        //-----------------------------------------------------------------------CREATING NEW SCHOOLCLASSES------------------------------------------------------
        public void GetSchoolClasses()
        {
            CommandPromtUtils utils = new CommandPromtUtils();
            List<SchoolClass> schoolClasses = new List<SchoolClass>();

            //Console.WriteLine("---- Starting Recording Process ----");

            do
            {
                schoolClasses.Add(GetSchoolClassesInfo());
            }
            while (utils.AskUserToExitRecording());
            PrintRawData(schoolClasses);
        }
        private SchoolClass GetSchoolClassesInfo()
        {
            CommandPromtUtils utils = new CommandPromtUtils();
            SchoolClass schoolClass = new SchoolClass();
            Console.WriteLine("---- Recording a new Schoolclass ----");
            schoolClass.Course     = utils.GetCourseInfo();
            schoolClass.Trainer    = utils.GetTrainers(schoolClass.Course.Title);
            schoolClass.Assignment = utils.GetAssignments();
            schoolClass.Students   = utils.GetStudents();
            return (schoolClass);
        }
        //-----------------------------------------------------------------------PRINT ALL LISTS-----------------------------------------------------------------4
        internal void PrintRawData(List<SchoolClass> schoolClasses)
        {
            CreateListData createListData = new CreateListData();
            createListData.CourseList(schoolClasses);
            createListData.TrainerList(schoolClasses);
            createListData.StudentList(schoolClasses);
            createListData.AssignmentList(schoolClasses);
        }
        

            


    }
}   
