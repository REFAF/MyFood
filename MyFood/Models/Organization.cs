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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int org_id { get; set; }

        public byte? city_id { get; set; }

        [Display(Name = "الموقع")]
        public string org_location { get; set; }

        [Display(Name = "نوع الجهة")]
        public byte? orgType_id { get; set; }

        public City City { get; set; }

        public OrgType OrgType { get; set; }

        //Nav property to enable FK of Table AspNetUser
        public ApplicationUser ApplicationUser { get; set; }
        public string Id { get; set; }
    }
}