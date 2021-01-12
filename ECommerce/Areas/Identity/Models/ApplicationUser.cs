using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Areas.Identity.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "Họ")]
        public string FirstName { get; set; }
        [Display(Name = "Tên")]
        public string LastName { get; set; }
        [Display(Name="Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime BirthDay { get; set; }
        [Display(Name="Địa chỉ_1")]
        public string Address1 { get; set; }
        [Display(Name = "Quận_1")]
        public string District1 { get; set; }
    }
}
