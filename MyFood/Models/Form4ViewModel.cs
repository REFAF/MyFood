using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class ViewModelForm4
    {
        public List<SafetyTool> safetyTool { get; set; }

        public SafetyTool SafetyToolNav { get; set; }

        public byte? mealCategory_id { get; set; }
        public IEnumerable<MealCategory> mealCategoryIE { get; set; }
        public long form4A_id { get; set; }

        public string Emp1 { get; set; }
        public string Emp2 { get; set; }

        [ForeignKey("teamLeaderId")]
        [Display(Name = "رئيس الفريق")]
        public string team_leader_id { get; set; }
        public ApplicationUser teamLeaderId { get; set; }

        [ForeignKey("supId")]
        [Display(Name = "مشرف الصالات")]
        public string sup_id { get; set; }
        public ApplicationUser supId { get; set; }

        public int? meal_num { get; set; }

        public int? meal_weight { get; set; }

        public byte? sample_num { get; set; }

        public DateTime? packing_date { get; set; }

        public string day { get; set; }


        [ForeignKey("Order")]
        public long? order_id { get; set; }
        public Order Order { get; set; }

        public byte? unitId { get; set; }




    }
}