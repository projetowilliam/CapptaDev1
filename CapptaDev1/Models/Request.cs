namespace CapptaDev1.Models
{
    public class Request
    {
        public int requestCode { get; set; }
        public string date { get; set; }
        public int clientFk { get; set; }
        public int vehiculeFk { get; set; }
        public int employee { get; set; }
        public string value { get; set; }
    }
}
