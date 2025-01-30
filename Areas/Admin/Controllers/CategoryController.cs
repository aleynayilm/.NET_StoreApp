using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize("Admin")]
	public class CategoryController:Controller
	{
		public IActionResult Index() { 
		return View();
		}
	}
}
