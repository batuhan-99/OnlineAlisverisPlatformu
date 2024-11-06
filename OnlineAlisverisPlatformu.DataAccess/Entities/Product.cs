using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.DataAccess.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Ürün adı en fazla 100 karakter olabilir.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Fiyat zorunludur.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stok miktarı zorunludur.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stok miktarı 0 veya pozitif bir değer olmalıdır.")]
        public int StockQuantity { get; set; }

        
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
