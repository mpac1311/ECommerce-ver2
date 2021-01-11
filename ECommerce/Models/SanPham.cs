using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        [Display(Name = "Tên Sản Phẩm")]
        public string TenSP { get; set; }

        [Display(Name = "Đơn giá")]
        public decimal DonGia { get; set; }

        [Display(Name = "Hình ảnh")]
        public string HinhAnh { get; set; }

        [Display(Name = "Video")]
        public string Video { get; set; }

        [Display(Name = "Chi tiết SP")]
        public string ChiTietSP { get; set; }

        [Display(Name = "Số lượng")]
        public int SoLuong{ get; set; }

        [Display(Name = "Số lượng tối thiểu")]
        public int SoLuongMuaToiThieu { get; set; }

        [ForeignKey("Loai")]
        [Display(Name = "Loại")]
        public int MaLoai { get; set; }

        [ForeignKey("ThuongHieu")]
        [Display(Name = "Thương hiệu")]
        public int MaTH { get; set; }

        [ForeignKey("NhaCungCap")]
        [Display(Name = "Nhà cung cấp")]
        public int MaNhaCC { get; set; }

        [ForeignKey("TrangThaiSP")]
        [Display(Name = "Trạng thái sản phẩm")]
        public int MaTTSP { get; set; }


        public Loai Loai { get; set; }        
        public ThuongHieu ThuongHieu { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public TrangThaiSP TrangThaiSP { get; set; }
        public ChiTietDonHang ChiTietDonHang { get; set; }
    }
}
