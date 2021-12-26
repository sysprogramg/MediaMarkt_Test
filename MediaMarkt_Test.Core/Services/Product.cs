using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaMarkt_Test.Core.Interfaces;

namespace MediaMarkt_Test.Core.Services
{
    public class Product : IProduct
    {
        #region Injected Properties
        private readonly IProductRepository _productRepository;
        #endregion

        public Product(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        #region Implement Interfaces
        public void AddProduct(Entities.Product product)
        {
            _productRepository.AddProduct(product);
        }

        public Entities.Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public IList<Entities.Product> GetProductsByString(string searchString = null)
        {
            return _productRepository.GetProductsByString(searchString);
        }
        #endregion
    }
}