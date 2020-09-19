namespace SpeedrunComOrg.Api.Client.Models
{
  public class Item
  {
    [JsonProperty("rel")]
    public string Relationship { get; set; }
    public Uri Uri { get; set; }
  }
}
