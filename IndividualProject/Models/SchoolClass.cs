using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class SchoolClass
    {
        private Course _course;
        private List<Trainer> _trainer;
        private List<Student> _students;
        private List<Assignment> _assignment;

        public List<Trainer> Trainer
        {
            get { return (this._trainer); }
            set { this._trainer = value; }
        }
        public List<Student> Students
        {
            get { return (this._students); }
            set { this._students = value; }
        }
        public Course Course
        {
            get { return (this._course); }
            set { this._course = value; }
        }
        public List<Assignment> Assignment
        {
            get { return (this._assignment); }
            set { this._assignment = value; }
        }

        public override string ToString()
        {
            string trainers = string.Empty;
            foreach (var item in Trainer)
            {
                trainers += ",  " + (item); // to look at it again!!!!!!!!!!!!!!
            }
            return (trainers);
        }
    }
}
