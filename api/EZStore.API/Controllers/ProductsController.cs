using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZStore.API.Data;
using EZStore.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EZStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public ProductsController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await _storeContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<Product>>> GetById(int id)
        {
            var product = await _storeContext.Products.FindAsync(id);

            if (product is null)
                return NotFound();

            return Ok(product);
        }
    }
}