using Enumerations.Entities.Enums;

namespace Enumerations.Entities
{
  class Order
  {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString()
    {
      return $@"
        Id = {Id}
        Date = {Date}
        Status = {Status}
      ";
    }
  }
}