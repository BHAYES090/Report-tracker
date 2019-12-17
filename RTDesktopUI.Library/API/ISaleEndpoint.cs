using RTDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.API
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}