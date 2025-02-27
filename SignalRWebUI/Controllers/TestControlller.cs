using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class TestControlller : Controller
    {
        public IActionResult Sepet()
        {
            return View();
        }
    }
}
