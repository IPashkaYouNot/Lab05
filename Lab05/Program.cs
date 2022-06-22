using Lab05;
using Lab05.Logic;

var registry = new OrdersRegistry();

registry.AddOrder(new Order { Name = "  ", Surname = "Pavlichenko" });
registry.AddOrder(new Order { Name = null, Surname = "Pavlichenko" });
registry.AddOrder(new Order { Name = "Pasha", Surname = "Pavlichenko" });
registry.AddOrder(new Order { Name = "Pasha123", Surname = "Pavlichenko" });

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();

registry.ConsiderAll();

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();

registry.ClearFinishedOrders();

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();

registry.ConsiderAll();

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();