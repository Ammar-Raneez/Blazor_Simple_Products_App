using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProduct: ISearchProduct
    {
        private readonly IProductRepository productRepository;
        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(string filter = null)
        {
            return this.productRepository.GetProducts(filter);
        }
    }
}
