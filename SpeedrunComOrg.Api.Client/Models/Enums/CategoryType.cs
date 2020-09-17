using System.Runtime.Serialization;

namespace SpeedrunComOrg.Api.Client.Models.Enums
{
  public enum CategoryType
  {
    [EnumMember(Value = "per-game")]
    PerGame,
    [EnumMember(Value = "per-level")]
    PerLevel
  }
}
