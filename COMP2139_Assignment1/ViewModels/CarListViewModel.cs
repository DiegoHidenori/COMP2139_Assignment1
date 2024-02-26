using COMP2139_Assignment1.Models;

namespace COMP2139_Assignment1.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Cars { get; }
        public string? currentCategory { get; }

        public CarListViewModel(IEnumerable<Car> cars, string? category)
        {
            Cars = cars;
            currentCategory = category;
        }
    }
}
