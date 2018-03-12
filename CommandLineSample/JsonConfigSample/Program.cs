using System;
using Microsoft.Extensions.Configuration;

namespace JsonConfigSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("Class.json");
            var configuration = builder.Build();
            Console.WriteLine($"ClassNo:{configuration["ClassNo"]}");
            Console.WriteLine($"ClassDesc:{configuration["ClassDesc"]}");

            Console.WriteLine($"name:{configuration["Students:0:name"]},age:{configuration["Students:0:age"]}");
            Console.WriteLine($"name:{configuration["Students:1:name"]},age:{configuration["Students:1:age"]}");
            Console.WriteLine($"name:{configuration["Students:2:name"]},age:{configuration["Students:2:age"]}");

            Console.ReadLine();

        }
    }
}
