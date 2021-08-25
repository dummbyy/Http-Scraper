using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Threading.Tasks;
namespace HTTPScrape
{
    class Program
    {

        static void Main(string[] args)
        {
            Animes();
            Console.Read();
        }

        private static void Animes()
        {

            var url = "https://9anime.to/home";
            HtmlWeb web = new HtmlWeb();
            var doc = web.Load(url);
            var nodes = doc.DocumentNode.SelectNodes("/html/body/div[1]/div/aside[1]/section[2]/div[2]/ul/li[position()>1]"); // xPath of 'a'


            foreach (var item in nodes)
            {
                Console.WriteLine("Name:{0}\nEpisode:{1}\n",item.SelectSingleNode("a[2]").InnerText,item.SelectSingleNode("a[1]").InnerText);
            }
        }
    }
}
