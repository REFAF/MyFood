using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFood.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        //[Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        //[Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        //[Required]
        [Display(Name = "البريد الإلكتروني")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "البريدالإلكتروني")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [Display(Name = "تذكرني؟")]
        public bool RememberMe { get; set; }
    }

    public class UserRoleViewModel
    {
        public string UserId { get; set; }

        [Display(Name = "اسم الموظف")]
        public string Username { get; set; }
        public string Email { get; set; }

        [Display(Name = "الصلاحية")]
        public string Role { get; set; }
    }



    public class EmpRegisterViewModel
    {
        //public EmpRegisterViewModel()
        //{
        //    Roles = new List<string>();
        //}

        //public IList<string> Roles { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الهوية")]
        public long national_id { get; set; }

        public string UserName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "اسم الموظف")]
        public string name { get; set; }

        [Display(Name = "رقم الجوال")]
        public string PhoneNumber { get; set; }

        [Display(Name = "الصلاحية")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string UserRoles { get; set; }
        public byte? Team_id { get; set; }
        public TeamNumber TeamNumber { get; set; }

        public string Id { get; set; }

        [EmailAddress(ErrorMessage = "صيغة البريد الالكتروني غير صحيحة")]
        [Display(Name = "البريد الالكتروني")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Email { get; set; }


        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [StringLength(100, ErrorMessage = "  الحد الأدنى 6 أحرف, كلمة المرور يجب أن تحتوي على أحرف كبيرة وصغيرة ورمز على الأقل", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تأكيد كلمة المرور")]
        [Compare("Password", ErrorMessage = "كلمة المرور لا تتطابق")]
        public string ConfirmPassword { get; set; }
    }

    public class EditEmpViewModel
    {
        [Display(Name = "رقم الهوية")]
        public long national_id { get; set; }

        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم الموظف")]
        public string name { get; set; }

        [Display(Name = "رقم الجوال")]
        public string PhoneNumber { get; set; }

        [Display(Name = "الصلاحية")]
        public string UserRoles { get; set; }

        public string Id { get; set; }

        [EmailAddress(ErrorMessage = "صيغة البريد الالكتروني غير صحيحة")]
        [Display(Name = "البريد الالكتروني")]
        public string Email { get; set; }
        public string UserId { get; set; }

        [Display(Name = "اسم الموظف")]
        public string Username { get; set; }

        [Display(Name = "الصلاحية")]
        public string Role { get; set; }
    }

    public class IndvRegisterViewModel
    {
        public string UserName { get; set; }

        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        //[Display(Name = "رقم الجوال")]
        //public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "صيغة البريد الالكتروني غير صحيحة")]
        [Display(Name = "البريد الالكتروني")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Email { get; set; }


        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [StringLength(100, ErrorMessage = "  الحد الأدنى 6 أحرف, كلمة المرور يجب أن تحتوي على أحرف كبيرة وصغيرة ورمز على الأقل", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تأكيد كلمة المرور")]
        [Compare("Password", ErrorMessage = "كلمة المرور لا تتطابق")]
        public string ConfirmPassword { get; set; }

    }

    public class OrgRegisterViewModel
    {
        public string UserName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "اسم الجهة")]
        public string name { get; set; }

        [Display(Name = "رقم الجوال")]
        public string PhoneNumber { get; set; }
        

        [Display(Name = "الموقع")]
        public string org_location { get; set; }

        [Display(Name = "نوع الجهة")]
        public byte? orgType_id { get; set; }
        public IEnumerable<OrgType> orgType { get; set; }

        [EmailAddress(ErrorMessage = "صيغة البريد الالكتروني غير صحيحة")]
        [Display(Name = "البريد الالكتروني")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Email { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [StringLength(100, ErrorMessage = "  الحد الأدنى 6 أحرف, كلمة المرور يجب أن تحتوي على أحرف كبيرة وصغيرة ورمز على الأقل", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تأكيد كلمة المرور")]
        [Compare("Password", ErrorMessage = "كلمة المرور لا تتطابق")]
        public string ConfirmPassword { get; set; }

    }

    public class BenRegisterViewModel
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الهوية")]
        public long national_id { get; set; }

        [StringLength(50)]
        [Display(Name = "الاسم الثلاثي")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string name { get; set; }

        [Display(Name = "رقم الجوال")]
        public string PhoneNumber { get; set; }

        [Display(Name = "المدينة")]
        public byte? city_id { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المبنى")]
        public string address { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "اسم الحيّ")]
        public byte Neighborhood_id { get; set; }

        public IEnumerable<Neighborhood> Neighborhood { get; set; }

        [StringLength(50)]
        [Display(Name = "اسم ولي الأمر")]
        public string guardian { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "عدد أفراد الأسرة")]
        public byte? family_number { get; set; }

        [EmailAddress(ErrorMessage = "صيغة البريد الالكتروني غير صحيحة")]
        [Display(Name = "البريد الالكتروني")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Email { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [StringLength(100, ErrorMessage = " الحد الأدنى 6 أحرف, كلمة المرور يجب أن تحتوي على أحرف كبيرة وصغيرة ورمز على الأقل", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تأكيد كلمة المرور")]
        [Compare("Password", ErrorMessage = "كلمة المرور لا تتطابق")]
        public string ConfirmPassword { get; set; }
    }
    public class RegisterViewModel
    {
        //[Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        //[Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        //[Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
