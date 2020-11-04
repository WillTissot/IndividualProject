using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IndividualProject.Models
{
    class Assignment
    {
        //given submitted
        private string _title; //Individual Project Part A
        private string _description; //Η εκφώνηση
        private DateTime _subdatetime; // the date should be withing start and end date of the related course
        private int _oralmark;   //max20 min 0
        private int _totalmark; //max80 min 0 those two should make 100. total mark is the homework

        public string Title
        {
            get { return (_title); }
            set
            {
                TextInfo changeStringForm = new CultureInfo("en-US", false).TextInfo; // to check whether it does the title Titlecase!!!!
                this._title = changeStringForm.ToTitleCase(value); }                  // this should be removed from here!!!!
        }
        public string Description
        {
            get { return (_description); }
            set { this._description = value; } // to think whether I want a specific form of string for the description
        }
        public DateTime SubDateTime
        {
            get { return (_subdatetime); }
            set { this._subdatetime = Convert.ToDateTime(value); }
        }
        public int OralMark
        {
            get { return (_oralmark); }
            set { this._oralmark = Convert.ToInt32(value); }
        }
        public int TotalMark
        {
            get { return (_totalmark); }
            set { this._totalmark = Convert.ToInt32(value); }
        }

        public override string ToString()
        {
            return ($"The oral mark is {_oralmark} and the total mark of this assignment is {_totalmark}");
        }
    }
}
