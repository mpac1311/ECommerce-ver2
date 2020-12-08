using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class TinhTrangDH
    {
        [Key]
        public int MaTT { get; set; }
        [Display(Name = "Trạng thái đơn hàng")]
        public string TrangThaiDH { get; set; }
        public ICollection<DonHang> DonHangs { get; set; }
    }
}
