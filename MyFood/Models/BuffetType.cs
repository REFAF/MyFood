using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class BuffetType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int buffet_type_id { get; set; }

        [StringLength(30)]
        [Display(Name = "نوع الضيافة")]
        public string buffet_type_name { get; set; }
    }
}