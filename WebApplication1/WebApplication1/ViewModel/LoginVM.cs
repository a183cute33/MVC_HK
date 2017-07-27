using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.ValidateAttribute;

namespace WebApplication1.ViewModel
{
    public class LoginVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "帳號")]
        [Email("demo,twMVC,skilltree", ErrorMessage = "請使用別的名稱")]
        [RegularExpression(@"\w.+\@\w.+")]
        public string account { get;set;}

        [Required]
        [StringLength(20, ErrorMessage = "{0} 密碼必須 {2} 字元以上 {1} 字元以下", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string password { get; set; }

    }
}