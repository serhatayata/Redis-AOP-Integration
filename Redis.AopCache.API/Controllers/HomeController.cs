using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Redis.AopCache.API.Models;
using Redis.AopCache.API.Services;

namespace Redis.AopCache.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
		private readonly DemoService _demoService;

		public HomeController(DemoService demoService)
		{
			_demoService = demoService;
		}

        [HttpGet("Get")]
		public async Task<string> Get()
		{
			var model = await _demoService.GetTime();
			return $"{model.Id}:{model.Time}";
		}

		[HttpGet("GetProductsAsync")]
		public async Task<List<ProductModel>> GetProductsAsync()
		{
			var model = await _demoService.GetProductsAsync();
			return model;
		}

		[HttpGet("GetProducts")]
		public List<ProductModel> GetProducts()
		{
			var model = _demoService.GetProducts();
			return model;
		}
	}
}
