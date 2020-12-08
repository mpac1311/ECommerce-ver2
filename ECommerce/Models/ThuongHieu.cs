using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ThuongHieu
    {
        [Key]
        public int MaTH { get; set; }
        [Display(Name = "Tên Thương Hiệu")]
        public string TenTH { get; set; }
        [Display(Name = "Mô tả")]
        public string Mota { get; set; }
        public List<SanPham> sanPhams { get; set; }
    }
}
