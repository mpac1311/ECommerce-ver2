using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class DonHang
    {
        [Key]
        public int MaDH { get; set; }
        [Display(Name = "Ngày tạo đơn hàng")]
        public DateTime NgayTaoDH { get; set; }
        [Display(Name = "Ghi chú đơn hàng")]
        public string GhiChuDH { get; set; }
        [Display(Name = "Tên Khách Hàng ")]
        public string TenKH { get; set; }
        [Display(Name = "Địa chỉ nhận")]
        public string DiaChiNhan { get; set; }
        [Display(Name = "Quận")]
        public string District { get; set; }
        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }
        [Display(Name ="Email")]
        public string Email { get; set; }
        [ForeignKey("DonHang")]
        [Display(Name = "Mã Tình Trạng")]
        public int MaTT { get; set; }
        public TinhTrangDH TinhTrangDH { get; set; }
        [ForeignKey("PhiShip")]
        public int MaShip { get; set; }
        public PhiShip PhiShip { get; set; }
    }
}
