using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMarkt_Test.Core.Interfaces
{
    public interface IProductRepository
    {
        Entities.Product GetProductById(int id);
        IList<Entities.Product> GetProductsByString(string searchString = null);
        public void AddProduct(Entities.Product product);
    }
}
