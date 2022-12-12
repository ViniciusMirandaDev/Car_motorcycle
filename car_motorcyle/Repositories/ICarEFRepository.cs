using car_motorcyle.Entities;

namespace car_motorcyle.Repositories
{
    public interface ICarEFRepository
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Insert(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
