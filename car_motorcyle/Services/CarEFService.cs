using car_motorcyle.Entities;
using car_motorcyle.Models;
using car_motorcyle.Repositories;

namespace car_motorcyle.Services
{
    public class CarEFService : ICarEFService
    {
        private ICarEFRepository _repository;

        public CarEFService(ICarEFRepository repository)
        {
            _repository = repository;
        }

        public List<Car> GetAll()
        {
            return _repository.GetAll();
        }

        public Car GetById(int id)
        {
            var car = _repository.GetById(id);

            if (car == null)
            {
                return null;
            }

            return car;
        }

        public void Insert(InsertModel car)
        {
            _repository.Insert(new Car
            {
                Model = car.Model,
                Price = car.Price,
                Brand = car.Brand,
                LicensePlate = car.LicensePlate,
                ProductionDate = car.ProductionDate
            });
        }

        public void Update(Car car)
        {
            _repository.Update(car);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
