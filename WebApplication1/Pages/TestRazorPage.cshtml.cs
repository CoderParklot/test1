using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class TestRazorPageModel : PageModel
    {
        public string welcStr { get; set; } 
        public void OnGet()
        {
            welcStr = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}