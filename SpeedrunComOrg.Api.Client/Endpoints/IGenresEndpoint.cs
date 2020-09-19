using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IGenresEndpoint
  {
    [Get("/genres")]
    Task<SrcomApiClientResponse<IEnumerable<Genre>>> GetGenres();

    [Get("/genres/{id}")]
    Task<SrcomApiClientResponse<Genre>> GetGenre(string id);
  }
}
