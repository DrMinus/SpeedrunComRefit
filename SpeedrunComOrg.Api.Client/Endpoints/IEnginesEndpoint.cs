using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IEnginesEndpoint
  {
    [Get("/engines")]
    Task<SrcomApiClientResponse<IEnumerable<Engine>>> GetEngines();

    [Get("/engines/{id}")]
    Task<SrcomApiClientResponse<Engine>> GetEngine(string id);
  }
}
