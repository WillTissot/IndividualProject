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
        private string _title; 
        private string _description;
        private DateTime _subdatetime; 
        private float _oralmark;   //max20 min 0
        private float _totalmark; //max80 min 0 those two should make 100. total mark is the homework

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
            set { this._description = value; } 
        }
        public DateTime SubDateTime
        {
            get { return (_subdatetime); }
            set { this._subdatetime = Convert.ToDateTime(value); }
        }
        public float OralMark
        {
            get { return (_oralmark); }
            set { this._oralmark = Convert.ToInt32(value); }
        }
        public float TotalMark
        {
            get { return (_totalmark); }
            set { this._totalmark = Convert.ToInt32(value); }
        }

        public override string ToString()
        {
            return ($"The {_title} assignment with description: {_description}, had submission date {_subdatetime}" + 
                    $"The oral mark is {_oralmark} and the total mark of {_title} is {_totalmark}");
        }
    }
}   
