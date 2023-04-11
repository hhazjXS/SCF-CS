
using System;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Policy;
using System.Xml.Linq;


namespace WebCrawler
{
    internal class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        //将爬行的页面放在list表中
        List<string> list = new List<string>();

        static void Main(string[] args)
        {

            Crawler myCrawler = new Crawler();
            string startUrl = "http://www.cnblogs.com/dstang2000";
            if (args.Length > 1)
            {
                startUrl = args[0];
            }
            myCrawler.urls.Add(startUrl, false);
            new Thread(myCrawler.Crawl).Start();
        }
        //爬虫函数
        private void Crawl()
        {
            Console.WriteLine("开始爬行");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    foreach (string urllimit in list)
                        if (url == urllimit) current = url;


                }
                if (current == null || count > 10) { break; }
                Console.WriteLine("爬行" + current + "页面!");
                string document = DownLoad(current);

                //判断是否为要读的文档
                Regex ishtml = new Regex(@"^<!DOCTYPE html>"); //判断文档是否为HTML
                Regex ishtm = new Regex(@"^<!DOCTYPE htm>"); //判断文档是否为htm
                Regex isaspx = new Regex(@"^<!DOCTYPE aspx>"); //判断文档是否为aspx
                Regex isphp = new Regex(@"^<!DOCTYPE php>"); //判断文档是否为php
                Regex isjsp = new Regex(@"^<!DOCTYPE jsp>"); //判断文档是否为jsp
                urls[current] = true;
                count++; //count计数加一
                string temp = current;
                if (ishtml.IsMatch(document))
                {
                    Parse(document);//用来解析,并加入新的链接

                }
                else if (ishtm.IsMatch(document))
                {
                    Parse(document);

                }
                else if (isaspx.IsMatch(document))
                {
                    Parse(document);

                }
                else if (isphp.IsMatch(document))
                {
                    Parse(document);

                }
                else if (isjsp.IsMatch(document))
                {
                    Parse(document);

                }

                urls[current] = true;
                count++;

            }
            Console.WriteLine("爬行完成");
            Console.ReadLine();
        }
        public string DownLoad(string url)
        {
            //异常处理
            try
            {
                WebClient webclient = new WebClient();
                webclient.Encoding = Encoding.UTF8;
                string html = webclient.DownloadString(url);

                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);

            foreach (Match match in matches)
            {
                if (match.Value.IndexOf(" / ") == 0)
                    strRef = "http://www.cnblogs.com/dstang2000" + match.Value;//将相对地址转换为绝对地址
                else
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"');
                if (strRef.Length == 0) continue;

                if (urls[strRef] == null) { urls[strRef] = false; }

            }

        }
    }
}
