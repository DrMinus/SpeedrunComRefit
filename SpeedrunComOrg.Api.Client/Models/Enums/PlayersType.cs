using System.Runtime.Serialization;

namespace SpeedrunComOrg.Api.Client.Models.Enums
{
  public enum PlayersType
  {
    [EnumMember(Value = "exactly")]
    Exactly,
    [EnumMember(Value = "up-to")]
    UpTo
  }
}
