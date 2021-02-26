using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class OrgType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte orgType_id { get; set; }

        [StringLength(50)]
        [Display(Name ="اسم الجهة")]
        public string orgType_name { get; set; }
    }
}