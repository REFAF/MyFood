using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Beneficiary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الهوية")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public long national_id { get; set; }

        [Display(Name = "المدينة")]
        public byte? city_id { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المبنى")]
        public string address { get; set; }

        public byte Neighborhood_id { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم ولي الأمر")]
        public string guardian { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "عدد أفراد الأسرة")]
        public byte? family_number { get; set; }

        //Nav property to enable FK of Table AspNetUser
        public ApplicationUser ApplicationUser { get; set; }
        public string Id { get; set; } 

        public Neighborhood Neighborhood { get; set; }

    }
}