using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private TestService testSvc;
        private IHostingEnvironment hostingEvn;
        private IMemoryCache cache;
        private readonly ILogger<HomeController> _logger;
        public HomeController(TestService testSvc, IHostingEnvironment host,IMemoryCache mc, ILogger<HomeController> logger)
        {
            this.testSvc = testSvc;
            this.hostingEvn = host;
            this.cache = mc;
            this._logger = logger;
        }
        public IActionResult Index()
        {

            //logger.LogDebug("这是调试信息");
            //logger.LogWarning("这是警告");
            //logger.LogError("这是错误");

            //HttpContext.Session.SetString("age","hxx");//需要using Microsoft.AspNetCore.Http;

            //this.cache.Set<string>("name", "hxx"+DateTime.Now,TimeSpan.FromSeconds(20));
            //return View();

            //string contentPath = hostingEvn.ContentRootPath;//C:\Users\admin\source\repos\WebApplication1\WebApplication1
            //string wwwPath = hostingEvn.WebRootPath;//C:\Users\admin\source\repos\WebApplication1\WebApplication1\wwwroot
            //return Content(contentPath);

            //return View();
            //string str = null;
            //str.ToString();
            //return Content(testSvc.Hello());
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            LogService log = (LogService)HttpContext.RequestServices.GetService(typeof(LogService));
            string str=log.WriteLog("asdf");
            return Content(str);
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";
            //object value;
            //if(cache.TryGetValue("name",out value))
            //{
            //    return Content("缓存" + value);
            //}
            //else
            //{
            //    return Content("缓存过期啦");
            //}
            string res = HttpContext.Session.GetString("age");
            return Content(res.ToString());
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
    }
}
