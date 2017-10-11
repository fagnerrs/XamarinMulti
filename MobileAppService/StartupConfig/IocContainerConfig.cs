using Fwit.Genone.ApplicationService.Interfaces;
using Fwit.Genone.ApplicationService.Services;
using Fwit.Genone.Domain.ApplicationService;
using Fwit.Genone.Domain.Repository;
using Fwit.Genone.Domain.Services;
using Fwit.Genone.Infrastructure.Repository;
using Fwit.Genone.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Fwit.Genone.MobileAppService.StartupConfig
{
    public static class IocContainer
    {
        public static void SetReferences(this IServiceCollection services){
            services.AddSingleton<IItemRepository, ItemRepository>();
            services.AddTransient<IPersonAppService, PersonAppService>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPersonRepository, PersonRepository>();
        }
    }
}
