using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Organization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int org_id { get; set; }

        [StringLength(50)]
        public string org_name { get; set; }

        public byte? city_id { get; set; }

        public int? phone_num { get; set; }

        public string org_location { get; set; }

        public byte? orgType_id { get; set; }

        public City City { get; set; }

        public OrgType OrgType { get; set; }
    }
}