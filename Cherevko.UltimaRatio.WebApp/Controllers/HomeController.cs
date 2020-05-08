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
		private readonly ILogger<HomeController> logger;
		private readonly IVkHttpClient client;

		public HomeController(ILogger<HomeController> logger, IVkHttpClient client)
		{
			this.logger = logger;
			this.client = client;
		}

		[HttpGet]
		public IActionResult AboutUs()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Photos()
		{
			var response = client.GetPhotos().Result.Response;
			return View(response.Items);
		}

		[HttpGet]
		public IActionResult Hema()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Links()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Contacts()
		{
			return View();
		}
	}
}
