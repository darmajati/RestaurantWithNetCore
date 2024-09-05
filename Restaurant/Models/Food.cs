namespace Restaurant.Models
{
    public class Food
    {
        public int food_id { get; set; }
        public string food_name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }

        public List<Transaction>? Transactions { get; set; }
    }
}
