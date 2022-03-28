
using Microsoft.AspNetCore.Mvc;

namespace AU.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;
        
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            this.logger = logger;
            this._productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProducts(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductsByCategory(categoryUrl);
            return Ok(result);
        }

        [HttpGet("search/{searchtext}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> SearchProducts(string searchText)
        {
            var result = await _productService.SearchProducts(searchText);
            return Ok(result);
        }

        [HttpGet("searchsuggestions/{searchtext}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductSearchSuggestions(string searchText)
        {
            var result = await _productService.GetProductSearchSuggestions(searchText);
            return Ok(result);
        }

        [HttpGet("featured")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetFeatured()
        {
            var result = await _productService.GetFeaturedProducts();
            return Ok(result);
        }

        // Testing locally stored data
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
