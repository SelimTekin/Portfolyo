using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
	public class ExperienceController : Controller
	{
		public IActionResult ExperienceList()
		{
			return View();
		}
	}
}
