using CleanArchitecture.Core.ViewModels;

namespace CleanArchitecture.Core.Interfaces.Services
{
    public interface IProductService
    {
        ProductViewModel GetById(int id);
    }
}
