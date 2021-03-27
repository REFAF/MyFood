using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class TeamNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte Team_id { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم الفريق")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Team_name { get; set; }
    }
}