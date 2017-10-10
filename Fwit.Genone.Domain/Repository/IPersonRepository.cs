using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fwit.Genone.Domain.Entities;
using Fwit.Genone.Domain.ValueObjects;

namespace Fwit.Genone.Domain.Repository
{
    public interface IPersonRepository
    {
        Task AddCoordinate(long personId, Coordinate coordinate);

        Task<IEnumerable<Person>> GetFriends(long personId);
    }
}
