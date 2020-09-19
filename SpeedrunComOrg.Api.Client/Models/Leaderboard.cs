using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Leaderboard
  {
    public string Weblink { get; set; }
    public string Name { get; set; }
    public string Level { get; set; }
    public string Platform { get; set; }
    public string Region { get; set; }
    public bool? Emulators { get; set; }
    public bool VideoOnly { get; set; }
    public string Timing { get; set; }
    public Dictionary<string, string> Values { get; set; }
    public List<LeaderboardRun> Runs { get; set; }
    public List<Link> Links { get; set; }
  }
}
