using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class PackagingFollowUp
    {
        [Key]
        public int pack_followup_id { get; set; }

        public long? user_id { get; set; }

        public int? inputorder_id { get; set; }

        public bool? haire { get; set; }

        public bool? nails { get; set; }

        public bool? cloth { get; set; }

        public bool? cap { get; set; }

        public bool? mask { get; set; }

        public bool? gloves { get; set; }

        [Column(TypeName = "ntext")]
        public string note { get; set; }
    }
}