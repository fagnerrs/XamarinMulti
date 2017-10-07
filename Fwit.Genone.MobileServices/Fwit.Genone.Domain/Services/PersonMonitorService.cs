using System;
using System.Threading.Tasks;
using Fwit.Genone.Domain.Entities;
using Fwit.Genone.Domain.Repository;

namespace Fwit.Genone.Domain.Services
{
    public class PersonMonitorService
    {
        readonly IPushRepository pushRepository;

        public PersonMonitorService(IPushRepository pushRepository)
        {
            this.pushRepository = pushRepository;
        }

        public async Task Start(Guid personId, string message)
        {
            // get person
            var person = new Person();

            await pushRepository.Send(person, message, "start");
            
        }

		public async Task Stop(Guid personId)
		{
			var person = new Person();

			await pushRepository.Send(person, string.Empty, "stop");
		}
    }
}
