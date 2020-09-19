using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IDevelopersEndpoint
  {
    [Get("/developers")]
    Task<SrcomApiClientResponse<IEnumerable<Developer>>> GetDevelopers();

    [Get("/developers/{id}")]
    Task<SrcomApiClientResponse<Developer>> GetDeveloper(string id);
  }
}
