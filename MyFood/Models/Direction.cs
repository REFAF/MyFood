using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Direction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte direction_id { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم الجهة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string direction_name { get; set; }

        [StringLength(1)]
        [Display(Name = "رمز الجهة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string direction_symbol { get; set; }
    }
}