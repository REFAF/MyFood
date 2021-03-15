using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class SafetyTool
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int safetyTool_id { get; set; }

        public string staff_name { get; set; }

        public bool? clothing { get; set; }

        public bool? hair { get; set; }

        public bool? nails { get; set; }

        public bool? clothing_claean { get; set; }

        public bool? head_cover { get; set; }

        public bool? face_mask { get; set; }

        public int? gloves { get; set; }

        public string note { get; set; }

    }
}