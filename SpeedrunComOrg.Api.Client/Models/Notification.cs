using System;
using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Notification
  {
    public string Id { get; set; }
    public DateTime Created { get; set; }
    public string Status { get; set; }
    public string Text { get; set; }
    public Item Item { get; set; }
    public List<Link> Links { get; set; }
  }
}
