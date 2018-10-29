using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionScopeConsole.Model
{
  public class Delivery
  {
    public int DeliveryId { get; set; }
    public int SiteId { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string Content { get; set; }

  }
}
