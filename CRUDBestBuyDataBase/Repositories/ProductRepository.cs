using CRUDBestBuyDataBase.Models;
using Dapper;
using System.Data;

namespace CRUDBestBuyDataBase.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _conn;
    public ProductRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public IEnumerable<ProductModel> GetAllProducts()
    {
        return _conn.Query<ProductModel>("SELECT * FROM PRODUCTS;");
    }
}
