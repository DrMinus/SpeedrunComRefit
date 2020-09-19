using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IPlatformsEndpoint
  {
    [Get("/platforms")]
    Task<SrcomApiClientResponse<IEnumerable<Platform>>> GetPlatforms();

    [Get("/platforms/{id}")]
    Task<SrcomApiClientResponse<Platform>> GetPlatform(string id);
  }
}
