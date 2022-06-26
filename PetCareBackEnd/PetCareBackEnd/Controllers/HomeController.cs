using Microsoft.AspNetCore.Mvc;
using PetCareBackEnd.DAL;
using PetCareBackEnd.ViewModels;
using System.Linq;

namespace PetCareBackEnd.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.Slider=_context.Slider.ToList();

            return View(homeVM);
            
        }
    }
}
