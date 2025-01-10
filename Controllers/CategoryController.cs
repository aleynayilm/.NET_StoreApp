using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryManager _manager;
        public CategoryController(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            var model= _manager.CategoryR.FindAll(false);
            return View(model);
        }
    }
}
