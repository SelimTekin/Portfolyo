using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {

        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke() {

            var values = context.Skills.ToList();

            return View(values);

        }
    }
}
