using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class SyntheticData
    {
        public SyntheticData()
        {
            CreateandPrintSyntheticData();
        }

        private void CreateandPrintSyntheticData()
        {
            Course course1 = new Course();
            course1.Title = "C# Full-Time C-12";
            course1.Stream = "C#";
            course1.Type = "Full-Time";
            course1.StartDate = Convert.ToDateTime(("1/1/2020"));
            course1.EndDate = Convert.ToDateTime(("31/3/2020"));

            Student student1= new Student();
            student1.FirstName = "Vasilis";
            student1.LastName = "Softsis";
            student1.DateOfBirth = Convert.ToDateTime("21/2/1995");
            student1.TuitionFees = 2300;

            Assignment assignment = new Assignment();
            assignment.Title = "Math exercise";
            assignment.Description = "Solve the following Equations";
            assignment.SubDateTime = Convert.ToDateTime("30/3/2020");
            assignment.OralMark = 20;
            assignment.TotalMark = 80;

            Trainer trainer = new Trainer();
            trainer.FirstName = "Kostas";
            trainer.LastName = "Papadopoulos";
            trainer.Subject = course1.Title;

            Console.WriteLine("--------------------------------------------------Data Example-----------------------------------------------------------------");
            Console.WriteLine(course1);
            Console.WriteLine(trainer);
            Console.WriteLine(assignment);
            Console.WriteLine(student1);

        }
    }
}
