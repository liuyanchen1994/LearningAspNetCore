using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CommandLineSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>()
            {
                {"name","damon"},
                {"age","15" }
            };
            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(dictionary)
                .AddCommandLine(args);
            var configuration = builder.Build();


            Console.WriteLine($"name:{configuration["name"]}");
            Console.WriteLine($"age:{configuration["age"]}");
            Console.ReadLine();

        }
    }
}
