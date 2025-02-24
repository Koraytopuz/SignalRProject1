using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATableComponentPartial :ViewComponent
    {
        public IViewComponentResult InvokeAync()
        {
            return View();
        }
    }
}
