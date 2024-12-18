
namespace DotnetCore.Sample.DataContract.Abstractions
{
	/// <summary>
	/// 
	/// </summary>
	public class BaseResponse
	{
		/// <summary>
		/// 
		/// </summary>
		public virtual bool Success => string.IsNullOrEmpty(ErrorMessage);

		/// <summary>
		/// 
		/// </summary>
		public virtual string ErrorMessage { get; set; }
	}
}