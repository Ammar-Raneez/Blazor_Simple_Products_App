using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.SearchProductScreem
{
    public class SearchProduct
    {
        private readonly ProductRepository productRepository;
        public SearchProduct(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(string filter)
        {
            return this.productRepository.GetProducts(filter);
        }
    }
}
