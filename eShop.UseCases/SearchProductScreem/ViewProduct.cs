using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.SearchProductScreem
{
    public class ViewProduct
    {
        private readonly ProductRepository productRepository;

        public ViewProduct(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return this.productRepository.GetProduct(id);
        }
    }
}
