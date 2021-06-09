namespace CleanArchitecture.Core.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
