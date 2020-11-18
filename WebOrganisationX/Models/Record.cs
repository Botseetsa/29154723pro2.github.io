using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace WebOrganisationX.Models
{
    public partial class Record
    {
        public string RecId { get; set; }

        [DisplayName("Number of Companies Worked")]
        public string NumOfComW { get; set; }

        [DisplayName("Years in Current Role")]
        public string YearsInCurRole { get; set; }

        [DisplayName("Years At Company")]
        public string YearsAtCom { get; set; }

        [DisplayName("Total Working Years")]
        public string TotalWyears { get; set; }
    }
}
