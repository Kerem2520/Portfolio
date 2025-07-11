using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {

            ViewBag.Title = portfolioContext.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.Description = portfolioContext.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.Phone = portfolioContext.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.Email = portfolioContext.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.Address = portfolioContext.Contacts.Select(x => x.Address).FirstOrDefault();

            return View();
        }
    }
}
