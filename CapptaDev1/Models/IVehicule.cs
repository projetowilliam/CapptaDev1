namespace CapptaDev1.Models
{
    public interface IVehicule
    {
        int id { get; set; }
        string name { get; set; }
        string model { get; set; }
        string year { get; set; }
        string price { get; set; }
        string mark { get; set; }
    }
}
