namespace Test2
{
    public class Order
    {
        private readonly List<Dish> order;
        public Order()
        {
            order = new List<Dish>();
        }

        public void AddDish(Dish newDish)
        {
            if (newDish is null)
            {
                throw new ArgumentNullException(nameof(newDish));
            }
            else
            {
                order.Add(newDish);
            }
        }

        public void OrderPrice()
        {
            double sum = 0;
            var total = from d in order
                        select d.Price;
            foreach (var d in order)
            {
                sum += d.Price;
            }
            Console.WriteLine($"Сумма заказа составила {sum}");
        }
    }
}
