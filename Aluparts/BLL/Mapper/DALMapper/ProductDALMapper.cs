using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BLL.Domain;
using DAL.Models;

namespace BLL.Mapper.DALMapper
{
    public static class ProductDALMapper
    {
        public static Product ProductToDomain(ProductModels model)
        {
            return new Product
            {
                Id = model.ProductId,
                Name = model.ProductName,
                Price = model.Price,
                Quantity = model.Quantity,
                InStock = model.InStock
            };
        }
    }
}
