using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class FoodType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int food_type_id { get; set; }

        [Display(Name = "أرز")]
        public bool rice { get; set; }

        [Display(Name = "دجاج")]
        public bool chicken { get; set; }

        [Display(Name = "لحم")]
        public bool meat { get; set; }

        [Display(Name = "تمر")]
        public bool dates { get; set; }

        [Display(Name = "فاكهة")]
        public bool fruit { get; set; }

        [Display(Name = "قرصان")]
        public bool gursan { get; set; }

        [Display(Name = "معكرونة")]
        public bool pasta { get; set; }

        [Display(Name = "بوفيه")]
        public bool buffet { get; set; }

        [Display(Name = "ماء")]
        public bool water { get; set; }

        [Display(Name = "إدام")]
        public bool soup { get; set; }

        [Display(Name = "فطائر")]
        public bool pies { get; set; }

        [Display(Name = "خبز")]
        public bool bread { get; set; }

        [Display(Name = "حلا")]
        public bool dessert { get; set; }

        [Display(Name = "جريش")]
        public bool groats { get; set; }

        [Display(Name = "خضار")]
        public bool vegetables { get; set; }

        [Display(Name = "عصائر")]
        public bool juices { get; set; }
    }
}