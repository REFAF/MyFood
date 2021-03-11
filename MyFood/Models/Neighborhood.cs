using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Neighborhood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Neighborhood_id { get; set; }

        [StringLength(60)]
        [Display(Name = "اسم الحيّ")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Neighborhood_name { get; set; }

        public byte direction_id { get; set; }

        public Direction Direction { get; set; }
    }
}