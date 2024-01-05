using System;
using System.Net;

namespace ArgumentViewer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argument Viewer");
            Console.WriteLine("");
            Console.WriteLine("Lenght: " + args.Length);
            Console.WriteLine("");

            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"argument[{i}]: " + args[i]);
                var decodeValue = WebUtility.UrlDecode(args[i]);
                Console.WriteLine($"[UrlDecode]: " + decodeValue);
                Console.WriteLine("");
            }

            while (Console.ReadLine() != "Exist")
            { }
        }
    }
}
