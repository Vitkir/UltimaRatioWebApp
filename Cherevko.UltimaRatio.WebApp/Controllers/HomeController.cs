using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cherevko.UltimaRatio.WebApp.Models;

namespace Cherevko.UltimaRatio.WebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult AboutUs()
		{
			return View();
		}

		public IActionResult Photos()
		{
			return View();
		}

		public IActionResult Hema()
		{
			return View();
		}

		public IActionResult Links()
		{
			return View();
		}

		public IActionResult Contacts()
		{
			return View();
		}
	}
}
