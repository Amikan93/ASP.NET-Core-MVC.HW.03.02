using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.HomeWork._03.Controllers
{
    public class ShowOS : Controller
    {
        public IActionResult GetOperatingSystem()
        {
            string operatingSystem = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            return Content($"Server operating system is {operatingSystem}");
        }
    }
}
