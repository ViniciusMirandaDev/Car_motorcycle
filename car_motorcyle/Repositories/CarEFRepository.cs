using car_motorcyle.Context;
using car_motorcyle.Entities;
using Microsoft.EntityFrameworkCore;

namespace car_motorcyle.Repositories
{
    public class CarEFRepository : ICarEFRepository
    {
        private readonly CoreContext _context;

        public CarEFRepository(CoreContext context)
        {
            _context = context;
        }

        public List<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return _context.Cars.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var car = _context.Cars.FirstOrDefault(m => m.Id == id);

            if (car != null) throw new NullReferenceException();

            _context.Entry(car).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Insert(Car car)
        {
            _context.Entry(car).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(Car car)
        {
            _context.Entry(car).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
