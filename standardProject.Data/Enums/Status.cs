using System;
using System.Collections.Generic;
using System.Text;

namespace standardProject.Data.Enums
{
  public enum Status
  {
    InActive,
    Active
  }

  public enum OrderStatus
  {
    InProgress,
    Confirmed,
    Shipping,
    Success,
    Canceled
  }

  public enum TransactionStatus
  {
    Success,
    Failed
  }
}
