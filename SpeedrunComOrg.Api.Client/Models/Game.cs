using System;
using System.Collections.Generic;

namespace SpeedrunComOrg.Api.Client.Models
{
  public class Game
  {
    public string Id { get; set; }
    public GameNames Names { get; set; }
    public string Abbreviation { get; set; }
    public string Weblink { get; set; }
    public int Released { get; set; }
    public DateTime ReleaseDate { get; set; }
    public Ruleset Ruleset { get; set; }
    public bool RomHack { get; set; }
    public List<string> GameTypes { get; set; }
    public List<string> Platforms { get; set; }
    public List<string> Regions { get; set; }
    public List<string> Genres { get; set; }
    public List<string> Engines { get; set; }
    public List<string> Developers { get; set; }
    public List<string> Publishers { get; set; }
    public Dictionary<string, string> Moderators { get; set; }
    public DateTime Created { get; set; }
    public Assets Assets { get; set; }
    public List<Link> Links { get; set; }
  }
}
