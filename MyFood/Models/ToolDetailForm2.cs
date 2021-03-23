using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class ToolDetailForm2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long tool_detail_id { get; set; }

        [Display(Name = "الكمية")]
        public int? quantity { get; set; }

        [Display(Name = "الراجع ")]
        public int? returned_tools { get; set; }

        [Display(Name = " الملاحظات")]
        public string note { get; set; }


        [Display(Name = "اسم الصنف")]
        public int? tool_id { get; set; }
        public Tool Tool { get; set; }


        [Display(Name = "الوحدة")]
        public string tool_unit { get; set; }

        [ForeignKey("CarToolForm2")]
        public long? f2_id { get; set; }
        public CarToolForm2 CarToolForm2 { get; set; }
    }
}