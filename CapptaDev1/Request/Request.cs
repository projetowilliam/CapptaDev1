namespace SinalVeiculos.Models
{
    public class Request
    {
        public int id { get; set; }
        public int value { get; set; }
        public string responsibleForSale { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
        public string client { get; set; }
        public string cpfClient { get; set; }
        public string date { get; set; }
    }
}

