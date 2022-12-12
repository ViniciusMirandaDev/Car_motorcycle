using car_motorcyle.Entities;
using car_motorcyle.Models;
using car_motorcyle.Repositories;

namespace car_motorcyle.Services
{
    public class MotorcycleDapperService : IMotorcycleDapperService
    {
        private IMotorcycleDapperRepository _repository;

        public MotorcycleDapperService(IMotorcycleDapperRepository repository)
        {
            _repository = repository;
        }
        public List<Motorcycle> GetAll()
        {
            return _repository.GetAll();
        }

        public Motorcycle GetById(int id)
        {
            var motorcycle = _repository.GetById(id);

            if (motorcycle == null)
            {
                return null;
            }

            return motorcycle;
        }

        public void Insert(InsertModel motorcycle)
        {
            _repository.Insert(new Motorcycle
            {
                Model = motorcycle.Model,
                Price = motorcycle.Price,
                Brand = motorcycle.Brand,
                LicensePlate = motorcycle.LicensePlate,
                ProductionDate = motorcycle.ProductionDate,
            });
        }

        public void Update(Motorcycle motorcycle)
        {
            _repository.Update(motorcycle);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
