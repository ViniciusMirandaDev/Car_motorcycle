using car_motorcyle.Entities;
using car_motorcyle.Models;

namespace car_motorcyle.Services
{
    public interface ICarEFService
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Insert(InsertModel car);
        void Update(Car car);
        void Delete(int id);
    }
}
