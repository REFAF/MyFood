using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الفئة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public byte category_id { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم الفئة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string category_name { get; set; }
    }
}