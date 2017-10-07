using System;
using System.Threading.Tasks;
using Fwit.Genone.ApplicationService.Interfaces;
using Fwit.Genone.Domain.Repository;

namespace Fwit.Genone.ApplicationService.Services
{
    public class PersonAppService : IPersonAppService
    {
        readonly IPersonRepository personRepositoty;

        public PersonAppService(IPersonRepository personRepositoty)
        {
            this.personRepositoty = personRepositoty;
        }

        public async Task AddCoordinate(Guid personId, double lat, double lon){
            await personRepositoty.AddCoordinate(personId, new Domain.ValueObjects.Coordinate() {
                Latitude = lat,
                Longitude = lon
            });
        }
    }
}
