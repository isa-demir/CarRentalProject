﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 4, DailyPrice = 200, ModelYear = 2006, Description = "Pugeot Partner"},
                new Car{CarId = 2, BrandId = 5, ColorId = 2, DailyPrice = 500, ModelYear = 2022, Description = "Tesla Model 3"},
                new Car{CarId = 3, BrandId = 5, ColorId = 4, DailyPrice = 650, ModelYear = 2023, Description = "Tesla Cybertruck"},
                new Car{CarId = 4, BrandId = 3, ColorId = 7, DailyPrice = 600, ModelYear = 2019, Description = "Nissan GTR"},
                new Car{CarId = 5, BrandId = 2, ColorId = 1, DailyPrice = 300, ModelYear = 2016, Description = "Volkwagen Jetta"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        
    }
}
