﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var host = new WebHostBuilder()
            //   .UseKestrel()
            //   .UseContentRoot(Directory.GetCurrentDirectory())
            //   .UseIISIntegration()
            //   .UseStartup<Startup>()
            //   .UseUrls("http://0.0.0.0:5000/")
            //   .Build();

            // host.Run();
            
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseKestrel()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .UseIISIntegration()
               .UseStartup<Startup>()
               .UseUrls("http://0.0.0.0:5000/");
    }
}
