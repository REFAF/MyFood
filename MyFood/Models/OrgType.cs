using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class OrgType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "نوع الجهة")]
        public byte orgType_id { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [StringLength(50)]
        [Display(Name ="اسم الجهة")]
        public string orgType_name { get; set; }
    }
}