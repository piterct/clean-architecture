using CleanArchitecture.Core.InputModels;
using CleanArchitecture.Core.ViewModels;

namespace CleanArchitecture.Core.Interfaces.Services
{
    public interface IProductService
    {
        ProductViewModel GetById(int id);
        void Add(ProductInputModel productInputModel);
    }
}
