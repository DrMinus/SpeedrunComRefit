using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Engine
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public List<string> Links { get; set; }
  }
}
