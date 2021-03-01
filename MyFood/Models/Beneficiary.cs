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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="رقم الهوية")]
        public long ben_id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الاسم الثلاثي")]
        public string name { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الجوال")]
        public int? mobile { get; set; }

        [Display(Name = "المدينة")]
        public byte? city_id { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "العنوان")]
        public string address { get; set; }

        public byte? sector_id { get; set; }

        public string location { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم ولي الأمر")]
        public string guardian { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "عدد أفراد الأسرة")]
        public byte? family_number { get; set; }

        //Nav property to enable FK of Table AspNetUser
        public ApplicationUser ApplicationUser { get; set; }
        public string Id { get; set; } 

    }
}