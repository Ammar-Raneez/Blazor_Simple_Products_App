using eShop.CoreBusiness.Models;

namespace eShop.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}
