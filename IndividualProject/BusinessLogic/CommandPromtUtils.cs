using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace IndividualProject.BusinessLogic
{
    class CommandPromtUtils 
    {

        //-----------------------------------------------------------------------COURSE--------------------------------------------------------------------------
        public Course GetCourseInfo()
        {
            Course course    = new Course();

            Console.WriteLine("---- Recording Course Information ----");
            course.Stream    = AskDetail("Please enter the stream: ");
            course.Type      = AskDetail("Please enter the type: ");
            course.StartDate = Convert.ToDateTime(AskDetail("Please enter starting date: (i.e. 20/03/2000)"));
            course.EndDate   = Convert.ToDateTime(AskDetail("Please enter ending date: (i.e. 20/03/2000)"));
            course.Title     = AskDetail("Please enter course's code ") + " " + course.Stream + " " + course.Type;
            return (course);
        }
        //-----------------------------------------------------------------------TRAINERS ----------------------------------------------------------------------
        /* Creating List of Trainers for ONE course */
        public List<Trainer> GetTrainers(string course)
        {
            List<Trainer> trainers = new List<Trainer>();
            Console.WriteLine("---- Recording Trainers Information ----");
            do
            {
                trainers.Add(GetTrainerInfo(course));         
            } 
            while (AskUserToExitRecording());
            return (trainers);
        }
        /* Creating one list item type TRAINER */
        private Trainer GetTrainerInfo(string course)
        {
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Please enter the first name: ");
            trainer.LastName  = AskDetail("Please enter the last name: ");
            trainer.Subject   = course;
            return (trainer);
        }
        //-----------------------------------------------------------------------ASSIGNMENT----------------------------------------------------------------------
        
        public List<Assignment> GetAssignments(DateTime startDate, DateTime endDate)
        {
            List <Assignment> assignments = new List<Assignment>();
            Console.WriteLine("---- Recording Assignment Information ----");
            do
            {
                assignments.Add(GetAssignmentInfo(startDate, endDate));
            } 
            while (AskUserToExitRecording());
            return (assignments);
        }
    
        private Assignment GetAssignmentInfo(DateTime startDate, DateTime endDate)
        {
            Assignment assignment = new Assignment();
            Validations validations = new Validations();
            assignment.Title       = AskDetail("Please enter title: ");
            assignment.Description = AskDetail("Please enter description: ");
            assignment.SubDateTime = validations.ValidateSubDate(startDate, endDate);
            assignment.OralMark    = validations.ValidateMark(20, "Oral");
            assignment.TotalMark   = validations.ValidateMark(80, "Total");
            return (assignment);
        }
        //-----------------------------------------------------------------------STUDENT-------------------------------------------------------------------------

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("---- Recording Student Information ----");
            do
            {
                students.Add(GetStudentInfo());
            }
            while (AskUserToExitRecording());
            return (students);
        }

        private Student GetStudentInfo()
        {
            Student student     = new Student();
            Validations validations = new Validations();
            student.FirstName   = AskDetail("Please enter the first name: ");
            student.LastName    = AskDetail("Please enter the last name: ");
            student.DateOfBirth = validations.ValidateBirth();
            student.TuitionFees = validations.ValidateFees();
            return (student);
        }
        //-----------------------------------------------------------------------OTHER---------------------------------------------------------------------------
        public bool AskUserToExitRecording()
        {
            bool decideAboutRecording;
            Console.WriteLine("Press any key to continue or ESCAPE to exit recording");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                decideAboutRecording = false;
            }
            else
            {
                decideAboutRecording = true;
            }
            return (decideAboutRecording);
        }
        public string AskDetail(string message, List<string> subjects = null)
        {
            Console.Write(message);
            string result = Console.ReadLine();
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
    }
}
