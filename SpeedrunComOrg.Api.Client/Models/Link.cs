using Newtonsoft.Json;
using Refit;
using System;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Link
  {
    [JsonProperty("rel")]
    public string Relationship { get; set; }
    public Uri Uri { get; set; }
  }
}
