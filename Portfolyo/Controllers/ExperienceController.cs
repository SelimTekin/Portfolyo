using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class ExperienceController : Controller
	{
		PortfolioContext context = new PortfolioContext();

		public IActionResult ExperienceList()
		{
			var values = context.Experiences.ToList();
			return View(values);
		}

		[HttpGet] // sayfa yüklenince (sayfa ilk açılınca) çalışacak
		public IActionResult CreateExperience()
		{
			return View();
		}

		[HttpPost] // Sayfada bir butona tıklandığı zaman çalışır

		public IActionResult CreateExperience(Experience experience) // Experience sınıfından experience parametresi al
		{
			context.Experiences.Add(experience); // parametreden gönderdiğimiz değeri Experiences tablosuna ekle
			context.SaveChanges(); // Veritabanına değişiklikleri kaydet
			return RedirectToAction("ExperienceList"); // ExperienceList metdouna yönlendir
		}

		public IActionResult DeleteExperience(int id)
		{
			var value = context.Experiences.Find(id); // id'ye gööre bul
			context.Experiences.Remove(value); // value'dan gelen değeri sil
			context.SaveChanges(); // Veritabanına değişiklikleri kaydet
			return RedirectToAction("ExperienceList"); // ExperienceList metdouna yönlendir
		}

		[HttpGet] // Önce güncellenecek verileri bulmamız gerekiyor
		public IActionResult UpdateExperience(int id)
		{
			var value = context.Experiences.Find(id);
			return View(value); // value'daki değerler view dosyasındaki inputlar içine asp-for helper'ı sayesinde yerleşiyor
		}

		[HttpPost]
		public IActionResult UpdateExperience(Experience experience) // Deneyime göre güncelleme yapacağız. O yüzden parametre olarak aldık
		{
			context.Experiences.Update(experience); // Parametreden gelen değere göre güncelleme yap
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
