using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fwit.Genone.Domain.Entities;

namespace Fwit.Genone.ApplicationService.Interfaces
{
    public interface IPersonAppService
    {
        Task AddCoordinate(long personId, double lat, double lon);

        Task<IEnumerable<Person>> GetFriends(long personId);
    }
}
