using System;
using System.Threading.Tasks;

namespace hello_vsformac.Services
{
    public interface ILoginService
    {
        Task<bool> Login(string userName, string password);

        Task<string> RefreshToken(string token); 
    }
}
