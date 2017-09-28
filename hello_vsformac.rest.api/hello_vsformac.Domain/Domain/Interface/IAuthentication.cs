using System;
using System.Threading.Tasks;

namespace hello_vsformac.Domain.Interface
{
	public interface IAuthentication
	{
		Task<bool> Login(string userName, string password);
	}
}
