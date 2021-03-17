using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long order_id { get; set; }

        [Display(Name = "رقم الجوال")]
        public string phone_number { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "تاريخ المناسبة")]
        public DateTime? event_date { get; set; }

        
        [Display(Name = "وقت المناسبة")]
        public TimeSpan? event_time { get; set; }

        public DateTime? reservation_date { get; set; }

        [Display(Name = "اسم المكان")]
        public byte? unit_id { get; set; }
        public Unit Unit { get; set; }

        [Display(Name = "أخرى")]
        public string unit_name { get; set; }

        [Display(Name = " العنوان")]
        public string address { get; set; }

        [ForeignKey("BuffetType")]
        [Display(Name = "نوع الضيافة")]
        public int? buffet_type_id { get; set; }
        public BuffetType BuffetType { get; set; }

        [Display(Name = "عدد الصحون")]
        public int? plate_num { get; set; }

        [Display(Name = "عدد الضيوف")]
        public int? persons_num { get; set; }

        [ForeignKey("userId")]
        public string user_id { get; set; }
        public ApplicationUser userId { get; set; }

        [Display(Name = "رئيس الفريق")]
        [ForeignKey("empId")]
        public string emp_id { get; set; }
        public ApplicationUser empId { get; set; }

        [ForeignKey("supId")]
        [Display(Name = "مشرف صالات")]
        public string sup_id { get; set; }
        public ApplicationUser supId { get; set; }

        [Display(Name = "قبول")]
        public bool Accept { get; set; }

        [Display(Name = "رفض")]
        public bool Deny { get; set; }

    }
}