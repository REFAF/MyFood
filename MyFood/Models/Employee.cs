using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الهوية")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public long Emp_id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "اسم المستخدم")]
        public string Emp_name { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الجوال")]
        public int mobile { get; set; }

        public EmpRole EmpRole { get; set; }

        [Display(Name = "الصلاحية")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public byte? role_id { get; set; }
    }
}