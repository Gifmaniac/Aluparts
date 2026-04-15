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
    public static class OrderAPIMapper
    {
        public static Order ProductToDomain(ProductModels model)
        {
            return new Order
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
