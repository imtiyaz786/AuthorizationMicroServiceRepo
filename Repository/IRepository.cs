using Authorization.Models;
using Microsoft.Extensions.Configuration;

namespace Authorization.Repository
{
    public interface IRepository
    {
        
      

       public string GenerateJSONWebToken(IConfiguration _congig,Member memberDetail);
    }
}
