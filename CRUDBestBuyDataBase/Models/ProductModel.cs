namespace CRUDBestBuyDataBase.Models;

public class ProductModel
{
    public ProductModel()
    {
    }

    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int CategoryID { get; set; }
    public int OnSale { get; set; }
    public int StockLevel { get; set; }
}
