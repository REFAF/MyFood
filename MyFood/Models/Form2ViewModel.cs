using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Form2ViewModel
    {
        public List<ToolDetailForm2> toolDetailForm2 { get; set; }

        public long form2_id { get; set; }

        [Display(Name = "رقم السيارة")]
        public int? car_num { get; set; }

        [Display(Name = "تاريخ التسليم")]
        public DateTime? delivery_date { get; set; }

        [Display(Name = "رئيس الفريق")]
        [ForeignKey("team_leaderId")]
        public string team_leader_id { get; set; }
        public ApplicationUser team_leaderId { get; set; }

        [ForeignKey("supId")]
        [Display(Name = "مشرف صالات")]
        public string sup_id { get; set; }
        public ApplicationUser supId { get; set; }

        [Display(Name = "مدير الجمعية")]
        [ForeignKey("managerId")]
        public string manager_id { get; set; }
        public ApplicationUser managerId { get; set; }

        public long order_id { get; set; }
        public Order Order { get; set; }


        public long tool_detail_id { get; set; }

        [Display(Name = "الكمية")]
        public int? quantity { get; set; }

        [Display(Name = "الراجع ")]
        public int? returned_tools { get; set; }

        [Display(Name = " الملاحظات")]
        public string note { get; set; }

        [Display(Name = "اسم الصنف")]
        public int? tool_id { get; set; }
        public IEnumerable<Tool> Tool { get; set; }

        [Display(Name = "الوحدة")]
        public string tool_unit { get; set; }

        [ForeignKey("CarToolForm2")]
        public long? f2_id { get; set; }
        public CarToolForm2 CarToolForm2 { get; set; }

    }
}