using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = context.Abouts.Select(x => x.AboutTitle).FirstOrDefault();
            ViewBag.aboutSubDescription = context.Abouts.Select(x => x.AboutSubDescription).FirstOrDefault();
            ViewBag.aboutDetail=context.Abouts.Select(x=>x.AboutDetails).FirstOrDefault();
            return View(); 
        }
    }
}
