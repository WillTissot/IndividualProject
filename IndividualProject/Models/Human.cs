using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Human
    {
        private string _firstname;
        private string _lastname;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value; }
        }
        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value; }
        }

    }
}
