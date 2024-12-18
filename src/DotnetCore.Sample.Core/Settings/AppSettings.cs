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
		static public IConfigurationRoot _content { get; }

		/// <summary>
		/// Default constructor
		/// </summary>
		static AppSettings()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(AppContext.BaseDirectory)
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables();

			_content = builder.Build();
		}

		/// <summary>
		/// 
		/// </summary>
		public string ConnectionString => _content[nameof(ConnectionString)];

		/// <summary>
		/// 
		/// </summary>
		public string SampleDatabaseName => _content[nameof(SampleDatabaseName)];
	}
}