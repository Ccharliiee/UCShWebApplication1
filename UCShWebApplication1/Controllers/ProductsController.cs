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
        public async Task<ActionResult<List<Product>>> GetProductsAsync()
        {
            return await _vproStoreContext.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product?>> GetProductAsync(int id)
        {
            return await _vproStoreContext.Products.FindAsync(id);
        }
    }
}

