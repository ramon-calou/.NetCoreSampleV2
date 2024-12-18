using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.Sample.Core.Settings
{
	public interface ISettings
	{
		/// <summary>
		/// 
		/// </summary>
		string ConnectionString { get; }

        /// <summary>
        /// 
        /// </summary>
		string SampleDatabaseName { get; }
	}
}