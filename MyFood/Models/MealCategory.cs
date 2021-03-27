using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class MealCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم فئة الوجبات")]
        public byte mealCategory_id { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم فئة الوجبات")]
        public string mealCategory_name { get; set; }
    }
}