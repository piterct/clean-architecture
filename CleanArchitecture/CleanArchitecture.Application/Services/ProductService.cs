using CleanArchitecture.Core.InputModels;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.ViewModels;

namespace CleanArchitecture.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productInputModel)
        {

        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetByID(id);

            return new ProductViewModel(product.Title, product.Price);
        }
    }
}
