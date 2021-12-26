using MediaMarkt_Test.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Dapper;

namespace MediaMarkt_Test.Infrastrucure.Repositories
{
    internal class ProductRepository : DapperBase, Core.Interfaces.IProductRepository
    {
        #region Injected Properties
        private readonly IConfiguration _configuration;
        #endregion

        public ProductRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        #region Implement Interfaces
        public Product GetProductById(int id)
        {
            try
            {
                string stored = "product_GetById";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("intId", id);

                return MainDBConnection.QuerySingle<Product>(stored, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Product> GetProductsByString(string searchString = null)
        {
            try
            {
                string stored = "product_GetByString";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("strSearchString", searchString);

                return MainDBConnection.Query<Product>(stored, parameters, commandType: System.Data.CommandType.StoredProcedure).AsList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                string stored = "product_Insert";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("strName", product.Name);
                parameters.Add("strDescription", product.Desciption);
                parameters.Add("decPrice", dbType: System.Data.DbType.Decimal, size: 18, precision: 2, value: product.Price);
                parameters.Add("strFamily", product.Family);

                MainDBConnection.Execute(stored, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
