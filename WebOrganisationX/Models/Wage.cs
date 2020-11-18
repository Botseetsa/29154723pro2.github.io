using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace WebOrganisationX.Models
{
    public partial class Wage
    {
        public string WageId { get; set; }

        [DisplayName("Hourly Rate")]
        public string HourlyRate { get; set; }

        [DisplayName("Monthly Income")]
        public string MonthlyRate { get; set; }

        [DisplayName("OverTime")]
        public string OverTime { get; set; }
    }
}
