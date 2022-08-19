using eShop.CoreBusiness.Models;

namespace eShop.UseCases.PluginInterfaces.DataStore
{
    public interface ProductRepository
    {
        IEnumerable<Product> GetProducts(string filter);
        Product GetProduct(int Id);
    }
}
