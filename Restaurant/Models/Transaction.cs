namespace Restaurant.Models
{
    public class Transaction
    {
        public int transaction_id { get; set; }
        public int customer_id { get; set; }
        public int food_id { get; set; }
        public int qty { get; set; }
        public int total_price { get; set; }
        public DateTime transaction_date { get; set; }

        public Customer? Customer { get; set; }
        public Food? Food { get; set; }
    }
}
