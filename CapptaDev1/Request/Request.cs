namespace SinalVeiculos.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string ResponsibleForSale { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Client { get; set; }
        public string CpfClient { get; set; }
        public string Date { get; set; }
    }
}

