using Assignment_1_Football_MVC.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1_Football_MVC.Controllers
{
    public class FootballController : Controller
    {
        ShopEntities match = new ShopEntities();
        // GET: Football
        public ActionResult Football ()
        {
            return View("Football");
        }
        [HttpPost]
        public ActionResult AddDetails(FootballLeague f)
        {
            FootballLeague footballLeague = new FootballLeague();

            footballLeague.MatchId = f.MatchId;
            footballLeague.TeamName1 = f.TeamName1;
            footballLeague.TeamName2 = f.TeamName2; 
            footballLeague.Status = f.Status;
           
            if (f.Status == "Win") 
            {
                footballLeague.Points = 4;
                footballLeague.WinningTeam = f.WinningTeam;
            }
            else
            {
                footballLeague.Points = 2;
            }
            

            match.FootballLeagues.Add(footballLeague);
            match.SaveChanges();
            return Redirect("MatchDetails");

        }
        public ActionResult MatchDetails()
        {
            var mt = match.FootballLeagues.ToList();
            return View(mt);
        }
    }
}