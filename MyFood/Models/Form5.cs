using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Form5
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long form5_id { get; set; }

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

        [Display(Name = "عدد الوجبات")]
        public byte? meal_num { get; set; }

        [Display(Name = "الوزن")]
        public float? weight { get; set; }

        [Display(Name ="أسر")]
        public string families { get; set; }

        [Display(Name ="أفراد")]
        public string individual { get; set; }

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


        [ForeignKey("Neighborhood")]
        public byte? Neighborhood_id { get; set; }
        public Neighborhood Neighborhood { get; set; }


        [ForeignKey("NotHealthy")]
        public int? nothealthy_type_id { get; set; }
        public NotHealthy NotHealthy { get; set; }


        [ForeignKey("FoodType")]
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

        [Display(Name ="حالة التقرير")]
        public string report_status { get; set; }
    }
}