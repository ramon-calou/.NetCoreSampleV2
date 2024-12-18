using Microsoft.AspNetCore.Hosting;

namespace DotnetCore.Sample.Api
{
	class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IWebHostBuilder CreateHostBuilder(string[] args) =>
			Microsoft.AspNetCore.WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
