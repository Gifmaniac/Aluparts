using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Domain;
using BLL.Mapper.DALMapper;
using DAL.Models;
using DAL.Repository;

namespace BLL.Services
{
    public class ProductService (ProductRepository productRepository)
    {
        public readonly ProductRepository ProductRepository = productRepository;

        public Order GetProductById(int id)
        {
            ProductModels productById = ProductRepository.GetProductModelById(id);
            return OrderAPIMapper.ProductToDomain(productById);
        }
    }
}
