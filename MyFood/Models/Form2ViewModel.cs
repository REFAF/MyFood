using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class ViewModelForm2
    {

        public List<ToolDetailForm2> toolDetailForm2 { get; set; }

        public IEnumerable<Tool> ToolIE { get; set; }

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

        public ToolDetailForm2 ToolDetailNav { get; set; }

        public long order_id { get; set; }
        public Order Order { get; set; }


        

        public int tool_id { get; set; }

        public Tool ToolNav { get; set; }
    }
}