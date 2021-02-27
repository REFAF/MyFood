using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class UserType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "نوع المستخدم")]
        public byte userType_id { get; set; }

        [StringLength(50)]
        [Display(Name = "نوع المستخدم")]
        public string userType_name { get; set; }
    }
}