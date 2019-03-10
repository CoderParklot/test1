using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class TestService
    {
        private DataService dataSvc;
        public TestService(DataService ds)
        {
            this.dataSvc = ds;
        }
        public string Hello()
        {
            string res = dataSvc.GetCount().ToString();
            return "Hello world "+res;
        }
    }
}
