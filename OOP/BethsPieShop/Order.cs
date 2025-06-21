namespace delegateEvents
{
    public class Order
    {
        public int Id { get; private set; }
        public DateTime OrderFulfilmentDate { get; private set; }

        public List<OrderItem> OrderItems { get; }
        public bool Fulfilled { get; set; } = false;

        public Order()
        {
            Id = new RandomZ().Next(9999999);

            int numberofSeconds = new Random().Next(100);
            OrderFulfilmentDate = DateTime.Now.AddSeconds(numberofSeconds);

            OrderItems = new List<OrderItem>();
        }
    }
}
