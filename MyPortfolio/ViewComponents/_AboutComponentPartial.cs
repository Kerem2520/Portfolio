using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {   
            //ViewBag, controllerdan View'e veri taşır.
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.subDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();

            return View();
        }
    }
}
