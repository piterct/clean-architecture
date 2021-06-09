using CleanArchitecture.Core.Entities;
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
            var product = new Product();

            _productRepository.Add(product);
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetByID(id);

            return new ProductViewModel(product.Title, product.Price);
        }
    }
}
