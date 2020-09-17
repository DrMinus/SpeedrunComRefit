using SpeedrunComOrg.Api.Client.Models.Enums;
using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Category
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Weblink { get; set; }
    public CategoryType Type { get; set; }
    public string Rules { get; set; }
    public Players Players { get; set; }
    public bool Miscellaneous { get; set; }
    public IEnumerable<Link> Links { get; set; }
  }
}
