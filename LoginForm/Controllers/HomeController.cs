using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginForm.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View(new Repository().Products);
		}
	}
}