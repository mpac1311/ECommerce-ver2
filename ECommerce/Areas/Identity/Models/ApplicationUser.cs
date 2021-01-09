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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        [Display(Name="Địa chỉ_1")]
        public string Address1 { get; set; }
        [Display(Name = "Quận_1")]
        public string District1 { get; set; }
        [Display(Name = "Địa chỉ_2")]
        public string Address2 { get; set; }
        [Display(Name = "Quận_2")]
        public string District2 { get; set; }

    }
}
