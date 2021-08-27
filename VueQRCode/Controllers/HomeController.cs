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

        [HttpPost]
        public ActionResult Index(string HTTPURL)
        {
            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = HTTPURL.Split(stringSeparators, StringSplitOptions.None);
           
            string cc = @" ""共" + lines.Count() + @"筆資料""";
            //foreach (string s in lines)
            //{
            //    Console.WriteLine(s); 
            //}
            TempData["alert"] = @"<script>Swal.fire('更新成功!', " + cc +  @", 'success')</script>";
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
            NameValueCollection qscoll = GetUrlParams(HTTPURL);
            // 取得全部參數
            //foreach (var key in qscoll.AllKeys)
            //{
            //    Response.Write(string.Format("KeyAndValue: {0} / {1}<br>", key, qscoll[key]));
            //}
            // 取得單一參數
            //Response.Write(string.Format("KeyAndValue: {0} / {1}<br>", "id", qscoll.Get("id")));



            var p = string.IsNullOrEmpty(qscoll.Get("p") ) ? "" : string.Format(qscoll.Get("p"));
            var Tag = string.IsNullOrEmpty(qscoll.Get("Tag")) ? "" : string.Format(qscoll.Get("Tag"));
            var Tc = string.IsNullOrEmpty(qscoll.Get("Tc")) ? "" : string.Format(qscoll.Get("Tc"));
            var TagNo = string.IsNullOrEmpty(qscoll.Get("TagNo")) ? "" : string.Format(qscoll.Get("TagNo"));

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
            else if(TagNo != "")
            {
                ViewData["myurl"] = "序號 : " + TagNo.ToString() + "<br />建議定價: 400 <br /> 代理商: ABCD <br /> 經銷商: EFGH <br /> 授權區域: 高雄市";

            }
            else
            {
                ViewData["myurl"] = "";
            }
           
            ViewBag.Message = "ok";
            return View();
        }

        /// <summary>
        /// 剖析URL參數
        /// </summary>
        /// <param name="pURL"></param>
        /// <returns></returns>
        public NameValueCollection GetUrlParams(string pURL)
        {
            Uri uri = new Uri(pURL);
            return HttpUtility.ParseQueryString(uri.Query, System.Text.Encoding.UTF8);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}