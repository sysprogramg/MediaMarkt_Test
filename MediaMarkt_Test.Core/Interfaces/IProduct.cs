using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMarkt_Test.Core.Interfaces
{
    public interface IProduct
    {
        public void AddProduct(Entities.Product product);
        Entities.Product GetProductById(int id);
        IList<Entities.Product> GetProductsByString(string searchString = null);
    }
}
