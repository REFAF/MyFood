using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class NotHealthy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte nothealthy_type_id { get; set; }

        public string nothealthy_type_name { get; set; }

        [Display(Name = "اسم العامل")]
        public string Employee1_name { get; set; }

        [Display(Name = "اسم العامل")]
        public string Employee2_name { get; set; }

        [Display(Name = "ملاحظات")]
        public string note { get; set; }
    }
}