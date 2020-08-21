using AngleSharp.Html.Parser;
using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliParser.Work
{
    public class Avito
    {
        public static string GetPage(string url)
        {
            HttpRequest request = new HttpRequest();
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Accept-Language", "ru-Ru,ru;q=0.9,en-Us;q=0.8,en;q=0.7,af;q=0.6");
            request.AddHeader("Cache-Controll", "max-age=0");
            //request.AddHeader("Host", "aliexpress.ru");
            request.AddHeader("Referer", url);
            request.AddHeader("Upgrade-Insecure-Requests", "1");
            request.AddHeader(HttpHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webpmimage/apng,*/*;q=0.8");
            request.KeepAlive = true;
            request.UserAgent = Http.FirefoxUserAgent();
            string response = request.Get(url).ToString();

            return response;
        }

        public static string ParsTover(string response)
        {
            HtmlParser parser = new HtmlParser();
            var doc = parser.ParseDocument(response);

            string test = doc.QuerySelector("div.item__line").InnerHtml;

            List<string> Tover = new List<string>();

            foreach (var item in doc.QuerySelectorAll("ul.list-items>li.list-item"))
            {
                Tover.Add(item.TextContent);
            }

            return "";
        }
    }
}
