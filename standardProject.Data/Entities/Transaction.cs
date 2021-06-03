using standardProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace standardProject.Data.Entities
{
  public class Order
  {
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public int? UserId { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipEmail { get; set; }
    public string ShipPhoneNumber { get; set; }
    public OrderStatus Status { get; set; }

  }
}
