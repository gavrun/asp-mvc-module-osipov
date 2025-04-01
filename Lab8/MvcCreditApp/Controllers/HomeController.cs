using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcCreditApp.Data;
using MvcCreditApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace MvcCreditApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly CreditContext db;


        public HomeController(ILogger<HomeController> logger, CreditContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            var allCredits = db.Credits.ToList<Credit>();  // ToList() assumes Credit
            ViewBag.Credits = allCredits;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();

            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;

            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            db.Bids.Add(newBid);
            db.SaveChanges();

            return "Thank you for chosing us, " + newBid.Name + ". Takes 10 day to process your request.";
        }

        // 
        public ActionResult BidSearch(string name) 
        { 
            var allBids = db.Bids
                .Where(a => a.CreditHead.Contains(name))
                .ToList<Bid>();

            if (allBids.Count == 0)
            {
                return Content("No bids found for " + name);
            }

            return PartialView(allBids);
        }
    }
}
