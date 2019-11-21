using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSC4330APP.Tables
{
    class User
    {
        
  [PrimaryKey,AutoIncrement]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UniversityName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Role1 { get; set; }
        public string Role2 { get; set; }








    }
}
