using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Region
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int region_id { get; set; }

        [StringLength(15)]
        [Display(Name = "اسم المنطقة")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string region_name { get; set; }
    }
}