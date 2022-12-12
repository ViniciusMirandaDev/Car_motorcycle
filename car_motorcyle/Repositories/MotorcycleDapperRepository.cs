using car_motorcyle.Entities;
using Dapper;
using System.Data.SqlClient;

namespace car_motorcyle.Repositories
{
    public class MotorcycleDapperRepository : IMotorcycleDapperRepository
    {
        private readonly IConfiguration _configuration;
        public MotorcycleDapperRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Motorcycle> GetAll()
        {
            using SqlConnection connection = new(_configuration.GetConnectionString("Default"));

            var query = "SELECT * FROM Motorcycle";

            return connection.Query<Motorcycle>(query).ToList();
        }

        public Motorcycle GetById(int id)
        {
            using SqlConnection connection = new(_configuration.GetConnectionString("Default"));

            var query = "SELECT * FROM Motorcycle WHERE Id = @Id";

            return connection.QueryFirstOrDefault<Motorcycle>(query, new { Id = id });
        }

        public void Insert(Motorcycle motorcycle)
        {
            using SqlConnection connection = new(_configuration.GetConnectionString("Default"));

            var query = @"INSERT INTO motorcycle
                                            (Model,
                                            Price,
                                            Brand,
                                            LicensePlate,
                                            ProductionDate)
                                VALUES     (@Model,
                                            @Price,
                                            @Brand,
                                            @LicensePlate,
                                            @ProductionDate)";

            connection.Execute(query, new
            {
                Model = motorcycle.Model,
                Price = motorcycle.Price,
                Brand = motorcycle.Brand,
                LicensePlate = motorcycle.LicensePlate,
                ProductionDate = motorcycle.ProductionDate
            });
        }

        public void Update(Motorcycle motorcycle)
        {
            using SqlConnection connection = new(_configuration.GetConnectionString("Default"));

            var query = @"UPDATE motorcycle
                            SET     Model = @Model,
                                    Price = @Price,
                                    Brand = @Brand,
                                    LicensePlate = @LicensePlate,
                                    ProductionDate = @ProductionDate
                            WHERE  Id = @Id";

            connection.Execute(query, new
            {
                Id = motorcycle.Id,
                Model = motorcycle.Model,
                Price = motorcycle.Price,
                Brand = motorcycle.Brand,
                LicensePlate = motorcycle.LicensePlate,
                ProductionDate = motorcycle.ProductionDate
            });
        }
        public void Delete(int id)
        {
            using SqlConnection connection = new(_configuration.GetConnectionString("Default"));

            var query = @"DELETE FROM Motorcycle WHERE Id = @Id";

            connection.Execute(query, new
            {
                Id = id
            });
        }
    }
}
