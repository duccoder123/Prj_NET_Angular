using FirstProject.API.Data;
using FirstProject.API.Models.Domain;
using FirstProject.API.Models.DTOs;
using FirstProject.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody]CreateCategoryRequestDto request)
        {
            var category = new Category
            {
                Name = request.Name,
                HandleUrl = request.HandleUrl,
            };
            await _categoryRepository.CreateAsync(category);

            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                HandleUrl = category.HandleUrl,
            };

            
            return Ok();
        }
    }
}
