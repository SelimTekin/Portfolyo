using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke() {
            
            // ViewBag, Controller'dan View'e veri taşır
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault(); // Tek bir veri getiren yapı (Title gelecek)
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault(); // Tek bir veri getiren yapı (SubDescription gelecek)
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault(); // Tek bir veri getiren yapı (Details gelecek)

            return View();

        }
    }
}
