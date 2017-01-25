using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CityInfoCoreApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Running demo with Kestrel.");

            //var config = new ConfigurationBuilder()
            //            .AddCommandLine(args)
            //            .Build();

            //var builder = new WebHostBuilder()
            //            .UseContentRoot(Directory.GetCurrentDirectory())
            //            .UseConfiguration(config)
            //            .UseStartup<Startup>()
            //            .UseKestrel(options =>
            //            {
            //                if (config["threadCount"] != null)
            //                {
            //                    options.ThreadCount = int.Parse(config["threadCount"]);
            //                }
            //            })
            //            .UseUrls("http://localhost:5000");

            //var host = builder.Build();
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();

            //return 0;
        }
    }
}
