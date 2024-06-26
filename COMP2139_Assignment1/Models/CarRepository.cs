﻿using COMP2139_Assignment1.Data;

namespace COMP2139_Assignment1.Models
{
    public class CarRepository : ICarRepository
    {
        public readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> AllCars
        {
            get
            {
                return _appDbContext.Cars;
            }
        }

        public IEnumerable<Car> CarsHotDeals
        {
            get
            {
                return _appDbContext.Cars.Where(p => p.isHotDeal);
            }
        }

        public Car? GetCarById(int id)
        {
            return _appDbContext.Cars.FirstOrDefault(p => p.id == id);
        }
    }
}
