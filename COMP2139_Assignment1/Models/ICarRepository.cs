namespace COMP2139_Assignment1.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars { get; }
        IEnumerable<Car> CarsHotDeals { get; }
        Car? GetCarById(int carId);
    }
}
