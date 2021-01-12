using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class NhaCungCap
    {
        [Key]
        public int MaNhaCC { get; set; }
        [Display(Name ="Tên nhà cung cấp")]
        public string TenNhaCC { get; set; }
        [Display(Name = "Địa chỉ")]
        public string  DiaChi{ get; set; }
        [Display(Name = "Mã số thuế")]
        public string MaSoThue { get; set; }
        [Display(Name = "Số điện thoại")]
        public string Sdt { get; set; }
        public ICollection<SanPham> sanPhams { get; set; }

    }
}
