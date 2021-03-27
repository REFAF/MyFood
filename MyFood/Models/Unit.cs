using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Unit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الوحدة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public byte unit_id { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم الوحدة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string unit_name { get; set; }

        [Display(Name = "الفئة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public byte category_id { get; set; }

        public Category Category { get; set; }


        [Display(Name = "المنطقة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public byte direction_id { get; set; }

        public Direction Direction { get; set; }
    }
}