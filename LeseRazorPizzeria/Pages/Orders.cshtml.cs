using LeseRazorPizzeria.Data;
using LeseRazorPizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LeseRazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders { get; set; }
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
