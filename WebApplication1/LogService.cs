using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class LogService
    {
        public string WriteLog(string text)
        {
            return "异常日志: " + text;
        } 
    }
}
