using System;
using Fwit.Genone.Infrastructure.Database.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Fwit.Genone.MobileAppService.StartupConfig
{
    public static class EntityFrameworkConf
    {
        public static void SetEntityFramework(this IServiceCollection services){
			//services.AddIdentity<IdentityUser, IdentityRole>()
			//.AddEntityFrameworkStores<GenoneDbContext>()
			//.AddDefaultTokenProviders();

			services.AddDbContext<GenoneDbContext>(options =>
						options.UseInMemoryDatabase(Guid.NewGuid().ToString()));
        }
    }
}
