using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  [Headers("User-Agent: SpeedrunComOrg.Api.Client v0.0.1")]
  public interface ICategories
  {
    [Get("/categories/{id}")]
    Task<SrcomApiClientResponse<Category>> GetCategory(string id);

    //[Get("/categories/{id}/variables")]
    //Task<SrcomApiClientResponse<List<Variable>> GetVariablesForCategory(string id);

    //[Get("/categories/{id}/records")]
    //Task<SrcomApiClientResponse<List<Leaderboard>>> GetRecordsForCategory(string id);
  }
}
