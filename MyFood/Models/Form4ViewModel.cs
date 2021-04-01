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

        [Display(Name ="فئة الوجبات")]
        public byte? mealCategory_id { get; set; }
        public IEnumerable<MealCategory> mealCategoryIE { get; set; }
        public long form4A_id { get; set; }

        [Display(Name ="العامل الثاني")]
        public string Emp1 { get; set; }

        [Display(Name ="العامل الثالث")]
        public string Emp2 { get; set; }

        [ForeignKey("teamLeaderId")]
        [Display(Name = "رئيس الفريق")]
        public string team_leader_id { get; set; }
        public ApplicationUser teamLeaderId { get; set; }

        [ForeignKey("supId")]
        [Display(Name = "مشرف الصالات")]
        public string sup_id { get; set; }
        public ApplicationUser supId { get; set; }

        [Display(Name = "عدد الوجبات")]
        public int? meal_num { get; set; }

        [Display(Name = "وزن الوجبات")]
        public float? meal_weight { get; set; }

        [Display(Name = "عدد العينات")]
        public byte? sample_num { get; set; }

        [Display(Name ="تاريخ التعبئة")]
        public string packing_date { get; set; }
        //public DateTime? packing_date { get; set; }

        [Display(Name = "اليوم")]
        public string day { get; set; }


        [ForeignKey("Order")]
        public long? order_id { get; set; }
        public Order Order { get; set; }


        [Display(Name = "الفرقة")]
        public byte? Team_id { get; set; }

        [Display(Name = "الجهة")]
        public string directionSymbol { get; set; }

        [Display(Name = "المصدر")]
        public byte? categoryId { get; set; }

        [Display(Name = "رقم المناسبة")]
        public byte? unitId { get; set; }

        [Display(Name = "العامل الاول")]
        public string team_leader_name { get; set; }

    }
}