using Enumerations.Entities;
using Enumerations.Entities.Enums;

namespace Enumerations
{
  class Program
  {
    static void Main (string[] args)
    {
      var order = new Order {
        Id = 1,
        Date = DateTime.Now,
        Status = OrderStatus.PendingPayment
      };

      Console.WriteLine(order);

      var orderStatusToString = OrderStatus.PendingPayment.ToString();
      var orderStatusByString = Enum.Parse<OrderStatus>("Delivered");

      Console.WriteLine(orderStatusToString);
      Console.WriteLine(orderStatusByString);
    }
  }
}