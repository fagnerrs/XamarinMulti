using System;
using System.Threading.Tasks;
using Fwit.Genone.Domain.ValueObjects;

namespace Fwit.Genone.Domain.Repository
{
    public interface IPersonRepository
    {
        Task AddCoordinate(Guid personId, Coordinate coordinate);
    }
}
