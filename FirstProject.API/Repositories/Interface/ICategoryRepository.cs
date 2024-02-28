using FirstProject.API.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
