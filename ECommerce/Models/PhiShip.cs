using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class PhiShip
    {
        [Key]
        public int MaShip { get; set; }
        [Display(Name = "Tên Phi Ship")]
        public string TenPhiShip { get; set; }
        [Display(Name ="Giá Ship")]
        public decimal ShipPrice { get; set; }
        public ICollection<DonHang> DonHangs { get; set; }
    }
}
