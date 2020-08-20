using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliParser.Work
{
    public class Aliexpress
    {
        public static string GetPage(string url)
        {
            HttpRequest request = new HttpRequest();

            string response = request.Get(url).ToString();

            return null;
        }
    }
}
