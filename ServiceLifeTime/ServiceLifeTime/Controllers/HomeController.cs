
using Microsoft.AspNetCore.Mvc;
using ServiceLifeTime.Models;
using System.Diagnostics;

namespace ServiceLifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransientService _transientservice1;
        private readonly ITransientService _transientservice2;

        private readonly IScopedService _scopedservice1;
        private readonly IScopedService _scopedservice2;

        private readonly ISingletonService _singletonservice1;
        private readonly ISingletonService _singletonservice2;

        public HomeController(ILogger<HomeController> logger, ITransientService transientservice1, ITransientService transientservice2, IScopedService scopedservice1, IScopedService scopedservice2, ISingletonService single1, ISingletonService single2)
        {
            _logger = logger;
            _transientservice1 = transientservice1;
            _transientservice2 = transientservice2;
            _scopedservice1 = scopedservice1;
            _scopedservice2 = scopedservice2;

            _singletonservice1 = single1;
            _singletonservice2 = single2;
        }

        public IActionResult Index()
        {
            ViewBag.transient1 = _transientservice1.GetOperationID();
            ViewBag.transient2 = _transientservice2.GetOperationID();

            ViewBag.Scoped1 = _scopedservice1.GetOperationID();
            ViewBag.Scoped2 = _scopedservice2.GetOperationID();

            ViewBag.Singleton1 = _singletonservice1.GenerateRandomNumber();
            ViewBag.Singleton2 = _singletonservice2.GenerateRandomNumber();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}