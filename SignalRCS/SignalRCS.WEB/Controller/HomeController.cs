using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRCS.WEB.Controller
{
    public class HomeController : ControllerBase
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return Ok();
        }
    }
}
