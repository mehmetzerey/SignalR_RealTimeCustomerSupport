using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalR.WEB.Controller
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
