namespace SinalVeiculos.Models
{
    public interface IVehicule
    {
        int Id { get; set; }
        string Name { get; set; }
        string Model { get; set; }
        string Year { get; set; }
        string Price { get; set; }
        string Brand { get; set; }
    }
}
