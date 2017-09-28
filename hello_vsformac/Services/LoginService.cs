using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace hello_vsformac.Services
{
    public class LoginService : ILoginService
    {
        public LoginService()
        {
        }

        public async Task<bool> Login(string userName, string password)
        {
            return await Task.FromResult(string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace((password)));
        }

        public async Task<string> RefreshToken(string token)
        {
            Task _t = Task.Delay(5000);

            var result = Task.WhenAll(_t);

			result.Wait();
			
            if (result.Status == TaskStatus.RanToCompletion)
            {
				return await Task.FromResult<string>("Token created successfully");
			}
            else
            {
				return await Task.FromResult<string>("Error creating token");
			}
        }
    }
}
