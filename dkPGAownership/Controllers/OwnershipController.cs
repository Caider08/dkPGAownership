using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Threading.Tasks;

namespace dkPGAownership.Controllers
{
    public class OwnershipController : Controller
    {
        // GET: Ownership
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public async Task<ActionResult> ListTest()
        {
            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = true;

            List<string> myStrings = new List<string>();

            WebPage mysite = await Browser.NavigateToPageAsync(new Uri("http://localhost:65045/"));
            // var TestNode = mysite.Html.CssSelect(".navbar-collapse collapse").First();
            // var nextNode = mysite.Html.CssSelect(".nav navbar-nav").First();
           // var node = mysite.Html.SelectSingleNode()

            List<HtmlNode> TestNodes = mysite.Html.CssSelect(".nav navbar-nav").ToList<HtmlNode>();

           // List<HtmlNode> TestNodes = theseNodes.("li").ToList<HtmlNode>();
           // foreach(HtmlNode a in TestNodes)
           // {
              //  if(a.NodeType.Equals("a"))
               // {
                 //   myStrings.Add(a.InnerText);
               // }
           // }

            ViewBag.ListStringTest = myStrings;
            return View("ScrapeFanShare");
        }


        public async Task< ActionResult> ScrapeFanShare()
        {
            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = true;


            WebPage fanShareHome = await Browser.NavigateToPageAsync(new Uri("http://localhost:65045/"));
            HtmlNode TestNode = fanShareHome.Html.CssSelect(".navbar-brand").First();
            string SignIn = TestNode.InnerText;

            ViewBag.InnerTextTest = SignIn;
            return View("ScrapeFanShare");
        }
    }
}