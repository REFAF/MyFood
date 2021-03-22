using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class FoodReceiptForm3
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int f3_id { get; set; }

        [Display(Name ="رقم السيارة")]
        public byte? car_num { get; set; }

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
        public byte? kilos_exit_time { get; set; }

        [Display(Name = "عدد الكيلوات أثناء الوصول")]
        public byte? kilos_arrival_time { get; set; }

        [Display(Name = "عدد الكيلوات أثناء الرجوع")]
        public byte? kilos_return_time { get; set; }

        [StringLength(10)]
        public string note { get; set; }


        //public byte? staff_health_status_type_id { get; set; }

        public byte? nothealthy_type_id { get; set; }
        public NotHealthy NotHealthy { get; set; }

        [ForeignKey("SafetyToolEmp1")]
        public int? safety_id_emp1 { get; set; }
        public SafetyTool SafetyToolEmp1 { get; set; }

        [ForeignKey("SafetyToolEmp2")]
        public int? safety_id_emp2 { get; set; }
        public SafetyTool SafetyToolEmp2 { get; set; }

        [ForeignKey("SafetyToolEmp3")]
        public int? safety_id_emp3 { get; set; }
        public SafetyTool SafetyToolEmp3 { get; set; }

        [Display(Name = "الوجهة التي تم الاستلام منها")]
        [ForeignKey("Order")]
        public long order_id { get; set; }
        public Order Order { get; set; }
        public byte? food_type_id { get; set; }
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