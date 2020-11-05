using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Course
    {
        private string _title;
        private string _stream;
        private string _type;
        private DateTime _startdate;
        private DateTime _enddate;

        public string Title  //CB12 Full Time C#
        {
            get { return (this._title); }
            set 
            {
                TextInfo changeStringForm = new CultureInfo("en-US", false).TextInfo;
                this._title = changeStringForm.ToTitleCase(value);
            }
        }   //I could create the title from uniting stream and type and asking only the coding bootcamp (CB12)

        public string Stream
        {
            get { return (this._stream); }
            set
            {
                TextInfo changeStringForm = new CultureInfo("en-US", false).TextInfo;
                this._stream = changeStringForm.ToTitleCase(value);
            }
        }  //C# , Java, JS, Python MAKE A LIST ALSO!
        public string Type
        {
            get { return (this._type); }
            set
            {
                TextInfo changeStringForm = new CultureInfo("en-US", false).TextInfo;
                this._type = changeStringForm.ToTitleCase(value);
            }
        }  //full-time or part-time or online or hybrid full or hybrid part time 
        public DateTime  StartDate
        {
            get { return (this._startdate); }
            set
            {
                this._startdate = Convert.ToDateTime(value); //To check whether it prints the time too!!!!
            }
        } //    I can contraint the dates. Start from 1/1/2021 i.e.
        public DateTime EndDate
        {
            get { return (this._enddate); }
            set
            {
                this._enddate = Convert.ToDateTime(value); 
                /* To check whether it prints the time too!!!!
                 * should I convert here or in commandpromtutils??*/
            }
        }
        public override string ToString()
        {
            return ($"\nThe {_title} is under the {_stream} stream with {_type} type. It starts on {_startdate} and it end on {_enddate}");
        }
    }   
}
