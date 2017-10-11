using Fwit.Genone.Infrastructure.Database.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Fwit.Genone.MobileAppService.StartupConfig
{
    public static class AspNetIdentity
    {
        public static void SetIdentityConfig(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<GenoneDbContext>()
            .AddDefaultTokenProviders();



        }
    }
}
