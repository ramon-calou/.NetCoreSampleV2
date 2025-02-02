using System;
using Microsoft.Extensions.Configuration;

namespace DotnetCore.Sample.Core.Settings
{
	/// <summary>
	/// 
	/// </summary>
	public class AppSettings : ISettings
	{
		/// <summary>
		/// 
		/// </summary>
		static public IConfigurationRoot Content { get; }

		/// <summary>
		/// Default constructor
		/// </summary>
		static AppSettings()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(AppContext.BaseDirectory)
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables();

			Content = builder.Build();
		}

		/// <summary>
		/// 
		/// </summary>
		public string ConnectionString => Content[nameof(ConnectionString)];

		/// <summary>
		/// 
		/// </summary>
		public string SampleDatabaseName => Content[nameof(SampleDatabaseName)];
    }
}