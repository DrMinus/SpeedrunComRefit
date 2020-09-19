using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface ILeaderboardsEndpoint
  {
    [Get("/leaderboards/{game}/category/{category}")]
    Task<SrcomApiClientResponse<Leaderboard>> GetLeaderboard(string game, string category);

    [Get("/leaderboards/{game}/level/{level}/{category}")]
    Task<SrcomApiClientResponse<Leaderboard>> GetLeaderboard(string game, string level, string category);
  }
}
