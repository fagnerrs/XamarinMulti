using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fwit.Genone.Domain.Entities;
using Fwit.Genone.Domain.Repository;
using Fwit.Genone.Domain.ValueObjects;

namespace Fwit.Genone.Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public async Task AddCoordinate(long personId, Coordinate coordinate)
        {
            await Task.FromResult(true);
        }

        public async Task<IEnumerable<Person>> GetFriends(long personId)
        {
            return await Task.FromResult(new List<Person>(){
                new Person(1,"Fagner"),
                new Person(2,"Viviane")
            });
        }
    }
}
