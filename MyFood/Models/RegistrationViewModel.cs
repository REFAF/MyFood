using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class OrgRegistrationViewModel
    {
        [StringLength(50)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الاسم")]
        public string name { get; set; }

        public string mobile { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "البريد الالكتروني")]
        public string email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تأكيد كلمة المرور")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public Organization Organization { get; set; }

        public int org_id { get; set; }

        public IEnumerable<OrgType> orgType { get; set; }
    }
}