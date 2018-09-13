using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace WebApplication1
{
    public class Program
    {
           public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseUrls(urls: "http://localhost:3501")

                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
  
}
