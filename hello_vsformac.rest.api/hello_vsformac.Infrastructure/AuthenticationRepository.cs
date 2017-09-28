using System;
using System.Threading.Tasks;
using hello_vsformac.Domain.Repository;

namespace hello_vsformac.Infrastructure
{
    public class AuthenticationRepository :IAuthenticationRepository
    {
        public Task<bool> Login(string userName, string password)
        {
            return Task.FromResult(true);
        }
    }
}
