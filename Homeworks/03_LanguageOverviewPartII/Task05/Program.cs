using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //parse the [protocol]://[server]/[resource]

            string URL = "http://academy.telerik.com/student-courses/seo-course";

            Regex reg = new Regex(@"\b(?<protocol>http://)(?<domain>.*\.[a-zA-Z0-9]{2,14}\.[a-z]{2,4})(?<resource>/.*)\b");

            Match m = reg.Match(URL);

            Group protocol = m.Groups["protocol"];
            Group domain = m.Groups["domain"];
            Group resource = m.Groups["resource"];


            Console.WriteLine("the protocol is {0}\nthe domain is {1} \nand the resource is {2}\n", protocol, domain, resource);       

        }
    }
}
