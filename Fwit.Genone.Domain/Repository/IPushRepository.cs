using System;
using System.Threading.Tasks;
using Fwit.Genone.Domain.Entities;

namespace Fwit.Genone.Domain.Repository
{
    public interface IPushRepository
    {
        Task Send(Person person, string message, string action);
    }
}
