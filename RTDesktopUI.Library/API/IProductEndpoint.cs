using RTDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.API
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}