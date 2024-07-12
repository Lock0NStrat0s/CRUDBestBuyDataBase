using CRUDBestBuyDataBase.Models;

namespace CRUDBestBuyDataBase.Repositories;

public interface IProductRepository
{
    public IEnumerable<ProductModel> GetAllProducts();
}
