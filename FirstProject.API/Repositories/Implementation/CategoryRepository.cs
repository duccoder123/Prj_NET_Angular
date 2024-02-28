using FirstProject.API.Data;
using FirstProject.API.Models.Domain;
using FirstProject.API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
            return category;
        }
    }
}
