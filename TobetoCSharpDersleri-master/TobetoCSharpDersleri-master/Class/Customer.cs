using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Customer
    {
        //Field
        //public string Name;

        //Property
        public int Id { get; set; }
        private string _firstname;
        public string FirstName 
        {
            get
            {
                return "Mr." + _firstname;
            }
            set
            {
                _firstname = value;
            } 
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
