using System;
using System.Threading.Tasks;
using Fwit.Genone.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fwit.Genone.MobileServices.Controllers
{
	[Route("api/[controller]")]
	public class PersonController : Controller
    {
        readonly IPersonAppService personAppService;

        public PersonController(IPersonAppService personAppService)
        {
            this.personAppService = personAppService;
        }

        [HttpPost]
        [Route("{id}/coordinate/{lat}/{lon}")]
        public async Task AddCoordinate(Guid personId, double lat, double lon)
        {
            await personAppService.AddCoordinate(personId, lat, lon);    
        }
    }
}
