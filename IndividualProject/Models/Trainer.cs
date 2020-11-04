using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Trainer
    {
        private string _firstname; // fields
        private string _lastname; // underscore is a usual thing for the fields
        private string _subject; // I should make a list of subjects. 

        public string FirstName 
        { 
            get { return (this._firstname);}
            set { this._firstname = value.ToUpper();} 
        } //properties
        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value.ToUpper(); }
        } //When I read first and last name for students i should use the same method! do not write the same code twice!
        public string Subject
        {
            get { return (this._subject); }
            set { this._subject = value.ToUpper(); }
        }

        public override string ToString()
        {
            return($"First Name: {_firstname}\tLast Name: {_lastname}\t Subject: {_subject}");
        }
    }

}
