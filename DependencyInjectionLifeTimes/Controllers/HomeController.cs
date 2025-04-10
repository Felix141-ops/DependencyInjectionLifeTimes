using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionLifeTimes.Models;
using DependencyInjectionLifeTimes.Dependencies;
using System.Text;

namespace DependencyInjectionLifeTimes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ISingletonGuidService _singleton1;
    private readonly ISingletonGuidService _singleton2;
    private readonly IScopedGuidService _scoped1;
    private readonly IScopedGuidService _scoped2;
    private readonly ITransientGuidService _transient1;
    private readonly ITransientGuidService _transient2;

    public HomeController(ILogger<HomeController> logger, 
        IScopedGuidService scoped1,
        IScopedGuidService scoped2, 
        ITransientGuidService transient1,
        ITransientGuidService transient2,
        ISingletonGuidService singleton1,
        ISingletonGuidService singleton2)
    {
        _logger = logger;
        _scoped1 = scoped1;
        _scoped2 = scoped2;
        _transient1 = transient1;
        _transient2 = transient2;
        _singleton1 = singleton1;
        _singleton2 = singleton2;
    }

    public IActionResult Index()
    {
        StringBuilder message = new StringBuilder();
        message.Append($"Transient1:{_transient1.GetGuid()}\n");
        message.Append($"Transient2:{_transient2.GetGuid()}\n");
        message.Append($"Singleton1:{_singleton1.GetGuid()}\n");
        message.Append($"Singleton2:{_singleton2.GetGuid()}\n");
        message.Append($"Scoped1:{_scoped1.GetGuid()}\n");
        message.Append($"Scoped2:{_scoped2.GetGuid()}\n");
        return Ok(message.ToString());
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
