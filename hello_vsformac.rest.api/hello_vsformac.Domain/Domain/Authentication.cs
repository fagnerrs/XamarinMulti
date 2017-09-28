using System;
using System.Threading.Tasks;
using hello_vsformac.Domain.Interface;
using hello_vsformac.Domain.Repository;

namespace hello_vsformac.Domain
{
    public class Authentication : IAuthentication
    {
        public Authentication(IAuthenticationRepository repository)
        {
            
        }

        public Task<bool> Login(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
