using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IGuestsEndpoint
  {
    [Get("/guests/{name}")]
    Task<SrcomApiClientResponse<Guest>> GetGuest(string name);
  }
}
