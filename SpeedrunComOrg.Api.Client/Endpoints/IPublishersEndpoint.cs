using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IPublishersEndpoint
  {
    [Get("/publishers")]
    Task<SrcomApiClientResponse<IEnumerable<Publisher>>> GetPublishers();

    [Get("/publishers/{id}")]
    Task<SrcomApiClientResponse<Publisher>> GetPublisher(string id);
  }
}
