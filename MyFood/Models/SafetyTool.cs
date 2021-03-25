using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class SafetyTool
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int safetyTool_id { get; set; }

        [Display(Name ="الاسم")]
        public string staff_name { get; set; }

        [Display(Name = "اللباس")]
        public bool clothing { get; set; }

        [Display(Name = "شعر الرأس")]
        public bool hair { get; set; }

        [Display(Name = "الأظافر")]
        public bool nails { get; set; }

        [Display(Name = "نظافة اللباس")]
        public bool clothing_claean { get; set; }

        [Display(Name = "غطاء الرأس")]
        public bool head_cover { get; set; }

        [Display(Name = "الكمام")]
        public bool face_mask { get; set; }

        [Display(Name = "القفاز")]
        public bool gloves { get; set; }

        [Display(Name = "ملاحظات")]
        public string note { get; set; }

        [ForeignKey("FoodReceiptForm3")]
        public long? f3_id { get; set; }
        public FoodReceiptForm3 FoodReceiptForm3 { get; set; }

    }
}