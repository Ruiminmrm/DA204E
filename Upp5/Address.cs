using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Upp5CD
{
    class Address
    {
        //input fields
        //instance variable
        private string street;
        private string zipcode;
        private string city;
        private Countries country;
        #region properties
        //Properties
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;
            }
        }
        public string Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }
        public Countries Countries
        {
            get { return country; }
            set { country = value; }
        }
        #endregion
        #region constructors
        //default contructors
        public Address(){}
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipcode = zip;
            this.city = city;
            this.country = country;
        }
        #endregion
        #region Methods
        //Methods
        //get a complete address label 
        public string GetAddressLabel()
        {
            string strout = street + Environment.NewLine;
            strout += zipcode + " " + city;
            return strout;
        }
        //delete the "_" from the country names and return the country name without the underscore char. 
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        //override th tostring method to return a string with the address detail fomated in one line 
        public override string ToString()
        {
            string strout = string.Format("{0, -25}, {1, -8}, {2, -10}, {3, 1}",
                street, zipcode, city, GetCountryString());
            return strout;
        }
        //check the input city is not null or empty
        public bool Validate()
        {
            bool ok = !string.IsNullOrEmpty(city);
            return ok;
        }
        #endregion
    }
}
