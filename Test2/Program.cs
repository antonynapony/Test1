using Test2;

class Program
{
    public static void Main(string[] args)
    {
        Order order = new Order();
        order.AddDish(new Dish() { Name = "Лосось", Price =  54.5});
        order.AddDish(new Dish() { Name  = "Фуагра", Price =  78});
        order.AddDish(new Dish() { Name  = "Ризотто", Price = 24 });
        order.AddDish(new Dish() { Name = "Паста", Price = 31.8 });

        order.OrderPrice();
    }   
}
