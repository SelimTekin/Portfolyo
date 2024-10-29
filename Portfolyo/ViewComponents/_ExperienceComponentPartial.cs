using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {

        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke() {

            var values = context.Experiences.ToList();

            return View(values);
        }
    }
}
