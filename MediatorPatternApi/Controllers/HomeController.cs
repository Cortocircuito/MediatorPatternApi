using MediatorPatternApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatorPatternApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController(
        INotifierMediatorService notifierMediatorService,
        ILogger<HomeController> logger)
        : ControllerBase
    {
        private readonly ILogger<HomeController> _logger = logger;

        [HttpGet("")]
        public ActionResult<string> NotifyAll()
        {
            notifierMediatorService.Notify("This is a test notification");
            return "Completed";
        }
    }
}
