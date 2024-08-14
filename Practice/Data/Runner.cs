using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Data
{
    class Runner
    {
        public static string UserEmail;
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Sex { get; set; }
        public string DateOfBirth { get; set; }
        public string CountryCode { get; set; }
        public Runner(string email, string password, string firstName, string lastname, string sex, string dateOfBirth, string countryCode)
        {
            Email = email;
            Password = password;
            FirstName = firstName;
            Lastname = lastname;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            CountryCode = countryCode;
        }
    }
}
