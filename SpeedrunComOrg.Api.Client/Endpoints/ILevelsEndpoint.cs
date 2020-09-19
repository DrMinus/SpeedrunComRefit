using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface ILevelsEndpoint
  {
    [Get("/levels/{id}")]
    Task<SrcomApiClientResponse<Level>> GetLevel(string id);

    [Get("/levels/{id}/categories")]
    Task<SrcomApiClientResponse<IEnumerable<Category>>> GetCategoriesForLevel(string id);

    //[Get("/levels/{id}/variables")]
    //Task<SrcomApiClientResponse<IEnumerable<Variable>>> GetVariablesForLevel(string id);

    //[Get("/levels/{id}/records")]
    //Task<SrcomApiClientResponse<IEnumerable<Record>>> GetRecordsForLevel(string id);
  }
}
