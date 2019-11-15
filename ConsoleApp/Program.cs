using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using BLL;
using DTO;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        static void Main(string[] args)
        {
            // HotelsManager = new HotelsManager(Configuration.GetConnectionString("default"));
            // Console.WriteLine(Configuration.GetConnectionString("default"));
            Class1Manager class1Manager = new Class1Manager(Configuration);

            List<Class1> list = class1Manager.GetAllClass1();

            foreach (var c in list)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
