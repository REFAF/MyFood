using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Form4A
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        [Column(TypeName = "date")]
        public DateTime? packing_date { get; set; }

        public string day { get; set; }


        [ForeignKey("Order")]
        public long? order_id { get; set; }
        public Order Order { get; set; }

        [ForeignKey("MealCategory")]
        public byte? mealCategory_id { get; set; }
        public MealCategory MealCategory { get; set; }

    }
}