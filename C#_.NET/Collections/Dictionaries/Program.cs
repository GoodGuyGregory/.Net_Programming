using System;
using System.Collections.Generic;


namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> config = new Dictionary<string, string>();

            config.Add("resolution", "1920X1080");
            config.Add("title", "MyWebsite");

            Console.WriteLine($"Title: {config["title"]}");
            Console.WriteLine($"Resolution: {config["resolution"]}");

            // iterates through the dictionary:
            foreach (var key in config)
            {
                Console.WriteLine($"Key: {key.Key}, Value: {key.Value}");
            }
        }
    }
}
