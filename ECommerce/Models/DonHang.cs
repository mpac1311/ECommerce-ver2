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
        public DateTime NgayTaoDH { get; set; }
        public string GhiChuDH { get; set; }
        public string TenKH { get; set; }
        public string DiaChiNhan { get; set; }
        public string SoDienThoai{ get; set; }
        public string Email { get; set; }
        [ForeignKey("Trang thai DH")]
        [DefaultValue(0)]
        public int MaTT { get; set; }
        public TinhTrangDH TinhTrangDH { get; set; }
    }
}
