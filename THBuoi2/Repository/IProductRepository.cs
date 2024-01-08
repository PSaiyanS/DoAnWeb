using THBuoi2.Models;

namespace THBuoi2.Repository
{

    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
	
		Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
