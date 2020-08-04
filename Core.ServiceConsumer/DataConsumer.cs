using System;
using System.Collections.Generic;
using Core.ServiceConsumer.Models;

namespace Core.ServiceConsumer
{
    public class DataConsumer : IData
    {
        public DataConsumer()
        {
        }

        public IEnumerable<CarItem> GetCarList()
        {
            var carList = new List<CarItem>();
            carList.Add(new CarItem { Brand = "Chevrolet", Line = "Aveo", Year = "2017" });
            carList.Add(new CarItem { Brand = "Mazda", Line = "Mazda 3", Year = "2019" });
            carList.Add(new CarItem { Brand = "Seat", Line = "Leon", Year = "2018" });
            carList.Add(new CarItem { Brand = "Chevrolet", Line = "Spark", Year = "2015" });
            carList.Add(new CarItem { Brand = "Chevrolet", Line = "avep", Year = "2019" });
            carList.Add(new CarItem { Brand = "Chevrolet", Line = "test", Year = "2020" });
            carList.Add(new CarItem { Brand = "Chevrolet", Line = "test", Year = "2020" });
            return carList;
        }
    }
}
