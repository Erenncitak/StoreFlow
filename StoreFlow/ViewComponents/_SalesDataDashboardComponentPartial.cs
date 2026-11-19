using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents
{
    public class _SalesDataDashboardComponentPartial : ViewComponent
    {
        private readonly StoreContext _context;

        public _SalesDataDashboardComponentPartial (StoreContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Orders.ToList();
            return View(values);
        }
    }
}
