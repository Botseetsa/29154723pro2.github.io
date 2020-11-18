using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace WebOrganisationX.Models
{
    public partial class Department
    {
        public string DepId { get; set; }


        [DisplayName("Department")]
        public string DeptType { get; set; }

        [DisplayName("Business Travel")]
        public string BusTravel { get; set; }

        [DisplayName("Job Level")]
        public string JobLevel { get; set; }

        [DisplayName("Job Role")]
        public string JobRole { get; set; }
    }
}
