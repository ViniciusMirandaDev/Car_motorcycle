using car_motorcyle.Entities;

namespace car_motorcyle.Repositories
{
    public interface IMotorcycleDapperRepository
    {
        List<Motorcycle> GetAll();
        Motorcycle GetById(int id);
        void Insert(Motorcycle motorcycle);
        void Update(Motorcycle motorcycle);
        void Delete(int id);
    }
}
