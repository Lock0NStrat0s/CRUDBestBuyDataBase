using CRUDBestBuyDataBase.Models;

namespace CRUDBestBuyDataBase.Repositories;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
    void UpdateProduct(Product product);
    public void InsertProduct(Product productToInsert);
    public IEnumerable<Category> GetCategories();
    public Product AssignCategory();

}
