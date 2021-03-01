using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class UserRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الاسم")]
        public string name { get; set; }
        public long? national_id { get; set; }

        public string mobile { get; set; }

        [EmailAddress]
        [Display(Name = "البريد الالكتروني")]
        public string email { get; set; }
        public bool? email_confirmed { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string password { get; set; }

        public UserType UserType { get; set; }

        [Display(Name = "نوع المستخدم")]
        public byte? userType_id { get; set; }



    }
}