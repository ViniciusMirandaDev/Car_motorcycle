using car_motorcyle.Entities;
using car_motorcyle.Models;

namespace car_motorcyle.Services
{
    public interface IMotorcycleDapperService
    {
        List<Motorcycle> GetAll();
        Motorcycle GetById(int id);
        void Insert(InsertModel motorcycle);
        void Update(Motorcycle motorcycle);
        void Delete(int id);
    }
}
