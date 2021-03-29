using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class ViewModelForm3
    {
        public List<SafetyTool> safetyTool { get; set; }
        public int f3_id { get; set; }

        [Display(Name = "رقم السيارة")]
        public int? car_num { get; set; }

        [Display(Name = "عدد العاملين")]
        public byte? staff_num { get; set; }

        [Display(Name = "التاريخ")]
        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [Display(Name = "اليوم")]
        [StringLength(50)]
        public string day { get; set; }

        [Display(Name = "سليم")]
        public bool healthy { get; set; }

        [Display(Name = "غير سليم")]
        public bool not_healthy { get; set; }

        [Display(Name = "عدد العربيات")]
        public byte? cart_num { get; set; }

        [Display(Name = "عدد القدور")]
        public byte? pot_num { get; set; }

        [Display(Name = "طعام صالح")]
        public bool edible { get; set; }

        [Display(Name = "طعام غير صالح")]
        public bool inedible { get; set; }

        [Display(Name = "وقت الخروج")]
        public TimeSpan? exit_time { get; set; }

        [Display(Name = "وقت الوصول")]
        public TimeSpan? arrival_time { get; set; }

        [Display(Name = "وقت الرجوع")]
        public TimeSpan? return_time { get; set; }

        [Display(Name = "عدد الكيلوات أثناء الخروج")]
        public int? kilos_exit_time { get; set; }

        [Display(Name = "عدد الكيلوات أثناء الوصول")]
        public int? kilos_arrival_time { get; set; }

        [Display(Name = "عدد الكيلوات أثناء الرجوع")]
        public int? kilos_return_time { get; set; }

        [StringLength(10)]
        public string note { get; set; }

        public byte? nothealthy_type_id { get; set; }
        public NotHealthy NotHealthy { get; set; }

        public SafetyTool SafetyToolNav { get; set; }

        [Display(Name = "الوجهة التي تم الاستلام منها")]
        [ForeignKey("Order")]
        public long order_id { get; set; }
        public Order Order { get; set; }
        public int? food_type_id { get; set; }
        public FoodType FoodType { get; set; }

        [ForeignKey("teamLeaderId")]
        [Display(Name = "رئيس الفريق")]
        public string team_leader_id { get; set; }
        public ApplicationUser teamLeaderId { get; set; }

        [ForeignKey("supId")]
        [Display(Name = "مشرف الصالات")]
        public string sup_id { get; set; }
        public ApplicationUser supId { get; set; }

    }
}