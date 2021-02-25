using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte city_id { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم المدينة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string city_name { get; set; }
    }
}