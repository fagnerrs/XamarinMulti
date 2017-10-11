using Fwit.Genone.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fwit.Genone.Controllers
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
        public async Task SaveCoordinate(long personId, double lat, double lon)
        {
            await personAppService.AddCoordinate(personId, lat, lon);
        }

        [HttpGet]
        [Route("{id}/friends")]
        public async Task<ActionResult> GetFriends(long id)
        {
            var friends = await personAppService.GetFriends(id);

            return Ok(friends);
        }
    }
}
