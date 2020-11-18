using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace WebOrganisationX.Models
{
    public partial class Education
    {
        public string EduId { get; set; }

        [DisplayName("Education Field")]
        public string EduField { get; set; }

        [DisplayName("Education Years")]
        public string EduYears { get; set; }
    }
}
