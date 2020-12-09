using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace VueQRCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["myurl"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult About(string HTTPURL)
        {
            NameValueCollection qscoll = HttpUtility.ParseQueryString(HTTPURL);

            var Tag = string.IsNullOrEmpty(qscoll["tag"]) ? "" : qscoll["tag"];
            //var Tc = string.IsNullOrEmpty(Request.QueryString["tc"]) ? "" : Request.QueryString["tc"];
            //var Page = string.IsNullOrEmpty(Request.QueryString["p"]) ? "" : Request.QueryString["p"];
            // Iterate through the collection.
            //StringBuilder sb = new StringBuilder();
            //foreach (String s in qscoll.AllKeys)
            //{
            //    sb.Append(s + " - " + qscoll[s] + "<br />");
            //}

            if (Tag != "")
            {
                    ViewData["myurl"] ="產品序號 : "+  Tag.ToString() + "<br />建議定價: 100 <br /> 代理商: ABCD <br /> 經銷商: EFGH <br /> 授權區域: 新北市、台北市、宜蘭縣";


            }
            else
            {
                ViewData["myurl"] = "";
            }
           
            ViewBag.Message = "ok";
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}