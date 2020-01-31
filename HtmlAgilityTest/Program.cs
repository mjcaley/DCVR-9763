using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HtmlAgilityTest
{
    public class Program
    {
        public static bool HtmlAgilityTest(string data)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(data);

            return true;
        }

        static void Main(string[] args)
        {
            var success = HtmlAgilityTest("<html><head><title>A Document</title></head><body><p>Hey there!</p></html>");
        }
    }
}
