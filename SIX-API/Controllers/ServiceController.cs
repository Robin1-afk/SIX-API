using Microsoft.AspNetCore.Mvc;
using SIX.DataLogic;
using SIX.DataLogic.Logic;

namespace SIX_API.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class ServiceController : Controller
    {
       
        [HttpGet("GetLista")] 
        public ActionResult GetLista() {

            var objec = UserLogic.intance.GetUserMOD();
            return Ok(objec);
        }
    }
}
