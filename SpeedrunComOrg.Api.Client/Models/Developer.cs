using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Developer
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public List<Link> Links { get; set; }
  }
}
