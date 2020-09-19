using Newtonsoft.Json;
using SpeedrunComOrg.Api.Client.Models.Enums;
using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Ruleset
  {
    [JsonProperty("show-milliseconds")]
    public bool ShowMilliseconds { get; set; }

    [JsonProperty("require-verification")]
    public bool RequireVerification { get; set; }

    [JsonProperty("require-video")]
    public bool RequireVideo { get; set; }

    [JsonProperty("run-times")]
    public List<string> RunTimes { get; set; }

    [JsonProperty("default-time")]
    public string DefaultTime { get; set; }

    [JsonProperty("emulators-allowed")]
    public bool EmulatorsAllowed { get; set; }
  }
}
