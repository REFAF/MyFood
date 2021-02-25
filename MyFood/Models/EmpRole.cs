using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class EmpRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "الصلاحية")]
        public byte role_id { get; set; }

        [StringLength(50)]
        [Display(Name = "الصلاحية")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string role_name { get; set; }

        [Display(Name = "ملاحظة")]
        public string note { get; set; }
    }
}