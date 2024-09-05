namespace Restaurant.Models
{
    public class Customer
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }

        public List<Transaction>? Transactions { get; set; }
    }
}
