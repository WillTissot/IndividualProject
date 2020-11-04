using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Trainer : Human
    {

        private string _subject; 
        
        public string Subject
        {
            get { return (this._subject); }
            set { this._subject = value.ToUpper(); }
        }

        public override string ToString()
        {
            return($"First Name: {FirstName} Last Name: {LastName} Subject: {_subject}");
        }
    }

}
