using Bmerketo.Models;
using Bmerketo.Helpers.Repositories;

namespace Bmerketo.Helpers.Services
{
    public class ShowCaseService
    {
        private readonly ProductRepository _productRepository;

        public ShowCaseService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ShowcaseModel> GetLatest()
        {
            var latestProduct = await _productRepository.GetLatestAsync();

            if (latestProduct != null)
            {
                var showcase = new ShowcaseModel()
                {
                    Ingress = "WELCOME TO MERKETO SHOP",
                    Title = latestProduct.Ingress,
                    ImageUrl = latestProduct.ImageUrl,
                    Button = new LinkButtonModel
                    {
                        Content = "SHOP NOW",
                        Url = $"/products/details/{latestProduct.ArticleNumber}",
                    }
                };

                return showcase;
            }

            return null!;
        }
    }
}
