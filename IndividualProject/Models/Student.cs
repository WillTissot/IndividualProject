using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student : Human
    {

        private DateTime _dateofbirth;
        private double _tuitionfees;
        private List<string> _titleOfAssignment;

        public List<string> TitleOfAssignment
        {
            get { return (this._titleOfAssignment); }
            set { this._titleOfAssignment = value; }
        }

        public DateTime DateOfBirth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value; }
        }

        public double TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value; }
        }

        public override string ToString()
        {
            return ($"The student {FirstName} {LastName}, born in {_dateofbirth.ToShortDateString()}, owes {_tuitionfees} euro in tuition fees");
        }           
    }   
}
