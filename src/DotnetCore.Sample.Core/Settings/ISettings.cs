namespace DotnetCore.Sample.Core.Settings
{
	/// <summary>
	/// 
	/// </summary>
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