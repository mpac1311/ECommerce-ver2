using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class TrangThaiSP
    {
        [Key]
        public int MaTTSP { get; set; }
        [Display(Name = "Trạng thái sản phẩm")]
        public string TrangThaiProduct { get; set; }
        public ICollection<SanPham> SanPhams  { get; set; }
    }
}
