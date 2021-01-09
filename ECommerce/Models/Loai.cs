using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        [Display(Name = "Tên Loại")]
        public string TenLoai { get; set; }
        public ICollection<SanPham> sanPhams { get; set; }
    }
}
