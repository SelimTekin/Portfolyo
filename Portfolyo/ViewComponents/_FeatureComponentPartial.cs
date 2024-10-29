using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList(); // portfolioContext'ten gelen Features tablosundaki verileri liste olarak getir
            return View(values); // values'tan gelen verileri döndür
        }
    }
}
