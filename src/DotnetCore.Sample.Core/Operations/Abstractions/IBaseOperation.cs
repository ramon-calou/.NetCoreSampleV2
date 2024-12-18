using System;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.Core.Operations.Abstractions
{
	/// <summary>
	/// 
	/// </summary>
	public interface IBaseOperation<TRequest, TResponse> : IDisposable
        where TRequest : BaseRequest
    	where TResponse : BaseResponse, new()
	{
		/// <summary>
		/// 
		/// </summary>
		TResponse Execute(TRequest request);

		/// <summary>
		/// Async method to validate an entity of type T 
		/// </summary>
		bool Validate(TRequest entity);
	}
}