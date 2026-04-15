using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductModels
    {
        [Key]
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required int Price { get; set; }
        public int Quantity { get; set; }

        [NotMapped]
        public bool InStock => Quantity > 0;

    }
}
