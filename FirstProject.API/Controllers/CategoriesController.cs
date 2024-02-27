using FirstProject.API.Data;
using FirstProject.API.Models.Domain;
using FirstProject.API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CategoriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody]CreateCategoryRequestDto request)
        {
            var category = new Category
            {
                Name = request.Name,
                HandleUrl = request.HandleUrl,
            };

            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                HandleUrl = category.HandleUrl,
            };

            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
