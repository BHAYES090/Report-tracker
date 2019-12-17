using System.Net.Http;
using System.Threading.Tasks;
using WPFTRACKERUI.Models;

namespace RTDesktopUI.Library.API
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}