using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface IGamesEndpoint
  {
    [Get("/games")]
    Task<SrcomApiClientResponse<IEnumerable<Game>>> GetGames();

    [Get("/games/{id}")]
    Task<SrcomApiClientResponse<Game>> GetGame(string id);

    [Get("/games/{id}/categories")]
    Task<SrcomApiClientResponse<IEnumerable<Category>>> GetCategoriesForGame(string id);

    //[Get("/games/{id}/levels")]
    //Task<SrcomApiClientResponse<IEnumerable<Level>>> GetLevelsForGame(string id);

    //[Get("/games/{id}/variables")]
    //Task<SrcomApiClientResponse<IEnumerable<Variable>>> GetVariablesForGame(string id);

    [Get("/games/{id}/derived-games")]
    Task<SrcomApiClientResponse<IEnumerable<Game>>> GetDerivedGames(string id);

    //[Get("/games/{id}/records")]
    //Task<SrcomApiClientResponse<IEnumerable<Record>>> GetRecordsForGame(string id);
  }
}
