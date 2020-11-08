using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject.BusinessLogic
{
    class CreateListData

        //and printing
    {
        //-----------------------------------------------------------------------COURSE LIST---------------------------------------------------------------------
        public void CourseList(List<SchoolClass> schoolClasses)
        {
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                Console.WriteLine(schoolClasses[i].Course);
            }
        }
        //-----------------------------------------------------------------------TRAINER LIST--------------------------------------------------------------------
        public void TrainerList(List<SchoolClass> schoolClasses)
        {
            var listOfTrainers = new List<Trainer>();
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                listOfTrainers = listOfTrainers.Union(schoolClasses[i].Trainer).ToList();
            }
            foreach (var item in listOfTrainers)
            {
                Console.WriteLine(item);
            }
        }
        //-----------------------------------------------------------------------STUDENT LIST--------------------------------------------------------------------
        public void StudentList(List<SchoolClass> schoolClasses)
        {
            List<Student> listOfStudents = new List<Student>();
            List<Student> entriesOfAllStudents = new List<Student>();
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                listOfStudents = listOfStudents.Union(schoolClasses[i].Students).ToList();
                entriesOfAllStudents = entriesOfAllStudents.Concat(schoolClasses[i].Students).ToList();
            }
            foreach (var item in listOfStudents)
            {
                Console.WriteLine(item);
            }
            StudentsAttedingMoreThanOne(entriesOfAllStudents);
        }
        public void StudentsAttedingMoreThanOne (List<Student> allStudents)
        {
            List<Student> duplicatedStudents = new List<Student>();
            for (int i = 0; i < allStudents.Count; i++)
            {
                if (allStudents[i].FirstName == allStudents[i+1].FirstName && allStudents[i].LastName == allStudents[i+1].LastName && allStudents[i].DateOfBirth == allStudents[i + 1].DateOfBirth)
                {

                }


            }
        }


        //-----------------------------------------------------------------------ASSIGNMENT LIST---------------------------------------------------------------------
        public void AssignmentList (List<SchoolClass> schoolClasses)
        {
            List<Assignment> listOfAssignments = new List<Assignment>();
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                listOfAssignments = listOfAssignments.Union(schoolClasses[i].Assignment).ToList();
            }
            foreach (var item in listOfAssignments)
            {
                Console.WriteLine(item);
            }
        }

        public void StudentsPerCourse(List<SchoolClass> schoolClasses)
        {
            for ( int i = 0; i < schoolClasses.Count; i++)
            {
                Console.WriteLine($"Regarding the {schoolClasses[i].Course.Title}, the following students are attending it: ");
                foreach (var item in schoolClasses[i].Students)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void TrainersPerCourse(List<SchoolClass> schoolClasses)
        {
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                Console.WriteLine($"Regarding the {schoolClasses[i].Course.Title}, the following trainers are teaching it: ");
                foreach (var item in schoolClasses[i].Trainer)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void AssignmentsPerCourse(List<SchoolClass> schoolClasses)
        {
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                Console.WriteLine($"Regarding the {schoolClasses[i].Course.Title}, the following assignments are part of it: ");
                foreach (var item in schoolClasses[i].Assignment)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void AssignmentsPerStudent(List<SchoolClass> schoolClasses)
        {
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                foreach (var item in schoolClasses[i].Students)
                {
                    Console.WriteLine($"The student {item.FirstName} {item.LastName} has the following assignments: ");
                    foreach (var item1 in schoolClasses[i].Assignment)
                    {
                        Console.WriteLine(item1);
                    }
                }
            }
        }
    }
}
