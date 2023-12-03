using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UCShWebApplication1.DbConnectHelper;
using UCShWebApplication1.Entities;

namespace UCShWebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProStoreContext _vproStoreContext;
        public ProductsController(ProStoreContext vproStoreContext)
        {
            _vproStoreContext = vproStoreContext;
        }

        [HttpGet(Name = "GetProducts")]
        public ActionResult<List<Product>> GetProducts()
        {
            return  _vproStoreContext.Products.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product?> GetProduct(int id)
        {
            return _vproStoreContext.Products.Find(id);
        }
    }
}

