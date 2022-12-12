namespace car_motorcyle.Entities
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }
        public string? LicensePlate { get; set; }
        public DateTime? ProductionDate { get; set; }
    }
}
