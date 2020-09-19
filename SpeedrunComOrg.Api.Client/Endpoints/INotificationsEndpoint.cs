using Refit;
using SpeedrunComOrg.Api.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedrunComOrg.Api.Client.Endpoints
{
  public interface INotificationsEndpoint
  {
    [Get("/notifications")]
    Task<SrcomApiClientResponse<IEnumerable<Notification>>> GetNotifications();
  }
}
