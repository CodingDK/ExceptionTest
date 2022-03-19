using CoreFrameworkTester.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFrameworkTester.Service
{
    public class CarService
    {
        public List<Car> NotImplementedExceptionMethod()
        {
            throw new NotImplementedException();

            var carsList = new List<Car>();

            carsList.Add(new Car()
            {
                Brand = "VW",
                Model = "Golf"
            });

            carsList.Add(new Car
            {
                Brand = "Ford",
                Model = "Transit"
            });

            var carsList1 = new List<Car>
            {
                new Car
                {
                    Brand = "Ford",
                    Model = "Transit"
                },
                new Car()
                {
                    Brand = "VW",
                    Model = "Golf"
                }
            };

            return carsList;
        }

        public List<Car> NotUsedMethod()
        {
            var carsList = new List<Car>();

            carsList.Add(new Car()
            {
                Brand = "VW",
                Model = "Golf"
            });

            carsList.Add(new Car
            {
                Brand = "Ford",
                Model = "Transit"
            });

            var carsList1 = new List<Car>
            {
                new Car
                {
                    Brand = "Ford",
                    Model = "Transit"
                },
                new Car()
                {
                    Brand = "VW",
                    Model = "Golf"
                }
            };

            return carsList;
        }

        public List<Car> GetAll()
        {
            var carsList = new List<Car>();

            carsList.Add(new Car()
            {
                Brand = "VW",
                Model = "Golf"
            });

            carsList.Add(new Car
            {
                Brand = "Ford",
                Model = "Transit"
            });

            return carsList; 
        }

        public void MakeException(List<Car> cars)
        {
            var car =  cars.FirstOrDefault();

            var orgBrand = car.Brand;
            var orgModel = car.Model;

            car.Brand = "Noget helt forkert";

            car.Model = "Noget helt forkert";

            if (int.Parse(car.Brand) == 1) //Fejler
            {
                car.Brand = orgBrand;
                car.Model = orgModel;
            }

            //Det her under sker aldrig

            car.Brand = "Noget helt forkert";

            car.Model = "Noget helt forkert";

            car.Brand = "Noget helt forkert";

            car.Model = "Noget helt forkert";

            car.Brand = "Noget helt forkert";

            car.Model = "Noget helt forkert";
        }
    }
}
