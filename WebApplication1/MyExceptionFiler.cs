using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MyExceptionFiler : IExceptionFilter
    {
        private ILogger logger;
        public MyExceptionFiler(ILoggerFactory logFac)
        {
            this.logger = logFac.CreateLogger(typeof(MyExceptionFiler));
        }
        public void OnException(ExceptionContext context)
        {
            this.logger.LogError("发生异常:" + context.Exception.Message);
        }
    }
}
