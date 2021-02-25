using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Diet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte diet_id { get; set; }

        [Required]
        public string diet_name { get; set; }

        [Column(TypeName = "ntext")]
        public string desc { get; set; }
    }
}