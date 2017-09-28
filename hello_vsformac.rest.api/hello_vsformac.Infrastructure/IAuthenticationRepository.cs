using System;
using System.Threading.Tasks;

namespace hello_vsformac.Domain.Repository
{
    public interface IAuthenticationRepository
    {
        Task<bool> Login(string userName, string password);
    }
}
