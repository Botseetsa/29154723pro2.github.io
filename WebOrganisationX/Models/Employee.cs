using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace WebOrganisationX.Models
{
    public partial class Employee
    {
        public string EmpId { get; set; }

        [DisplayName("First Name")]
        public string Fname { get; set; }

        [DisplayName("Last Name")]
        public string Lname { get; set; }

        [DisplayName("Age")]
        public string Age { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }

        
        public string Password { get; set; }
    }
}
