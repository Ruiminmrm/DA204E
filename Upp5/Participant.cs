using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Upp5CD
{
     class Participant
    {
        // instance variables
        // initialize strings
        private string firstname = string.Empty;
        private string lastname = "";// same as string.Empty

        // Aggregation - "has a" relation
        private Address address;
        
        #region properties
        public Address Address { get; set; }
        public string FirstName { get; set; }
        public string FullName 
        { 
            get{ return FirstName + " , " + LastName; } 
        }
        public string LastName { get; set; }
        #endregion

        #region constructors
        //create address object in the constructor 
        public Participant()
        {
            address = new Address();
        }
        #endregion
        
        #region methods
        //override tostring method with name and address formated details
        public override string ToString()
        {
            string strout = string.Format("{0, -20}",  address.ToString());
            return strout;
        }
        //check if the address and name are not null or empty 
        public bool Validate()
        {
            bool addressOK = address.Validate();
            bool nameOK = (!string.IsNullOrEmpty(firstname) && (!string.IsNullOrEmpty(LastName)));
            // both true , then it will return true 
            return addressOK && nameOK;
        }
        #endregion 
    }
}
