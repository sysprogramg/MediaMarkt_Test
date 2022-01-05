using MediaMarkt_Test.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMarkt_Test.WebAPI.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Injected Properties
        private readonly IProductRepository _productRepository;
        #endregion

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Core.Entities.Product>> GetProducts(string searchString = null) => _productRepository.GetProductsByString(searchString).ToList();

        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public ActionResult AddProduct([FromForm]Core.Entities.Product product)
        {
            try
            {
                _productRepository.AddProduct(product);
                return Ok(200);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
