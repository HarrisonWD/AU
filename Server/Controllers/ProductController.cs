using AU.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AU.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AU.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;

        private readonly AUContext _context;

        public ProductController(ILogger<ProductController> logger, AUContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        
        //private static List<Models.Product> Products = new List<Models.Product>
        //{
        //    new Models.Product
        //    {
        //        Id = 1,
        //        Name = "Ashes of Creation",
        //        Description = "Cool MMORPG made by Intrepid",
        //        Image = "test",
        //        Price = 99.99m
        //    },
        //    new AU.Server.Models.Product
        //    {
        //        Id = 2,
        //        Name = "World of Warcraft",
        //        Description = "Cool MMORPG made by Blizzard",
        //        Image = "test",
        //        Price = 19.99m
        //    },
        //    new AU.Server.Models.Product
        //    {
        //        Id = 3,
        //        Name = "New World",
        //        Description = "Cool MMORPG made by Amazon",
        //        Image = "test",
        //        Price = 29.99m
        //    },
        //    new AU.Server.Models.Product
        //    {
        //        Id = 4,
        //        Name = "Red Dead Redemption",
        //        Description = "Cool Western game made by Rockstar",
        //        Image = "test",
        //        Price = 99.99m
        //    },
        //    new AU.Server.Models.Product
        //    {
        //        Id = 5,
        //        Name = "GTA V",
        //        Description = "Cool Open world pvp, pve game",
        //        Image = "test",
        //        Price = 99.99m
        //    },
        //    new AU.Server.Models.Product
        //    {
        //        Id = 6,
        //        Name = "Skyrim",
        //        Description = "Cool RPG game made by Bethesda",
        //        Image = "test",
        //        Price = 89.99m
        //    }

        //};
    }
}
