using THBuoi2.Models;

namespace THBuoi2.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);        
        Task DeleteAsync(int id);
    }
}
