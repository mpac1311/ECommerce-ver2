using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ChiTietDonHang
    {
        [Key, Column(Order = 0)]
        public int MaDH { get; set; }
        [Key, Column(Order = 1)]
        public int MaSP { get; set; }
        [Display(Name = "Số lượng sản phẩm")]
        public int SoLuongSP{ get; set; }
        [Display(Name = "Số tiền")]
        public int SotienSP{ get; set; }
        [Display(Name = "Tổng tiền")]
        public int TongTienDH { get; set; }
        public DonHang DonHang { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }

    }
}
