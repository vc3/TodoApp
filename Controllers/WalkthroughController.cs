using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoApp.Controllers
{
    public class WalkthroughController : Controller
    {
        public ActionResult Index(string step)
        {
			string title = "Todo App Walkthrough";

			// Humanize walkthrough step name
			if (!string.IsNullOrEmpty(step))
			{
				string[] stepWords = step.Split('-');
				string stepText = string.Join(" ", stepWords.Select(w => w == "and" || w == "to" ? w : w.Substring(0, 1).ToUpper() + w.Substring(1).ToLower()).ToArray());
				title += ": " + stepText;
			}

			ViewBag.step = step;
			ViewBag.Title = title;
            return View();
        }
    }
}
