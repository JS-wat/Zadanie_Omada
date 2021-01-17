using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Forms
{
    public class BookDemoData
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Company { get; }
        public string JobTitle { get; }
        public string BusinessEmail { get; }
        public string Phone { get; }
        public string Country { get; }
        public string NumOfEmpl { get; }

        public BookDemoData(string firstName, string lastName, string company, string jobTitle, string businessEmail, string phone, string country, string numOfEmpl)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            JobTitle = jobTitle;
            BusinessEmail = businessEmail;
            Phone = phone;
            Country = country;
            NumOfEmpl = numOfEmpl;
        }




    }
}
