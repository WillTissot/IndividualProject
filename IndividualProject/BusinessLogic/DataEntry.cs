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
            schoolClass.Assignment = utils.GetAssignments(schoolClass.Course.StartDate, schoolClass.Course.EndDate);
            schoolClass.Students   = utils.GetStudents(schoolClass.Assignment);

            return (schoolClass);
        }
        //-----------------------------------------------------------------------PRINT ALL LISTS-----------------------------------------------------------------
        internal void PrintRawData(List<SchoolClass> schoolClasses)
        {
            CreateListData createListData = new CreateListData();
            Console.WriteLine("--------------------------------------------------Printing Courses' List-------------------------------------------------------");
            createListData.CourseList(schoolClasses);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------Printing Trainers' List------------------------------------------------------");
            createListData.TrainerList(schoolClasses);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------Printing Students' List------------------------------------------------------");
            List<Student> allEntries = createListData.StudentList(schoolClasses);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------Printing Assignments' List---------------------------------------------------");
            createListData.AssignmentList(schoolClasses);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------Printing Students per Course List--------------------------------------------");
            createListData.StudentsPerCourse(schoolClasses);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------Printing Trainers per Course List--------------------------------------------");
            createListData.TrainersPerCourse(schoolClasses);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------Printing Assignments per Course List-----------------------------------------");
            createListData.AssignmentsPerCourse(schoolClasses);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------Printing Assignments per Students List---------------------------------------");
            createListData.AssignmentsPerStudent(schoolClasses);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------Printing Students who attend two or more lessons-----------------------------");
            createListData.StudentsAttedingMoreThanOne(allEntries);

            Console.WriteLine();
            Console.WriteLine("--------------------------Printing the students who have to submit their assignments within a specific week--------------------");
            DateSearchForDeadlines dateSearchForDeadlines = new DateSearchForDeadlines();
            dateSearchForDeadlines.GetDeadlines(schoolClasses);


        }
        

            


    }
}   
