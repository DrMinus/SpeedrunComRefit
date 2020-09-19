using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Level
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Weblink { get; set; }
    public string Rules { get; set; }
    public List<Link> Links { get; set; }
  }
}
