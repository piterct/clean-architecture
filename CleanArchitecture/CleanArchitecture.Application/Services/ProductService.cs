using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Core.Interfaces.Repositories;

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
            return new ProductViewModel();
        }
    }
}
