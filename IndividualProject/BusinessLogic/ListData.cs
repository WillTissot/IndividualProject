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
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                listOfStudents = listOfStudents.Union(schoolClasses[i].Students).ToList();
            }
            foreach (var item in listOfStudents)
            {
                Console.WriteLine(item);
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
    }
}
