using System;
using System.Threading.Tasks;

namespace Fwit.Genone.ApplicationService.Interfaces
{
    public interface IPersonAppService
    {
        Task AddCoordinate(Guid personId, double lat, double lon);
    }
}
