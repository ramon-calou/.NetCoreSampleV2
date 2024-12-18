using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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