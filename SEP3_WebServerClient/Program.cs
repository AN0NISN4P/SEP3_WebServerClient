using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3_WebServerClient {
	public class Program {
		public static void Main2(string[ ] args) {
			
			
			CreateHostBuilder(args).Build( ).Run( );
		}

		public static IHostBuilder CreateHostBuilder(string[ ] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder => {
					webBuilder.UseStartup<Startup>( );
				});
	}
}
