using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الهوية")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public long national_id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "رقم الفريق")]
        public byte? Team_id { get; set; }
        public TeamNumber TeamNumber { get; set; }
    }
}