using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IGameTypesEndpoint
  {
    [Get("/gametypes")]
    Task<SrcomApiClientResponse<IEnumerable<GameType>>> GetGameTypes();

    [Get("/gametypes/{id}")]
    Task<SrcomApiClientResponse<GameType>> GetGameType(string id);
  }
}
