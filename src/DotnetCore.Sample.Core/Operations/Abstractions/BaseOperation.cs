using System;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.Core.Operations.Abstractions
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseOperation<TRequest, TResponse> : IBaseOperation<TRequest, TResponse>
		where TRequest : BaseRequest
		where TResponse : BaseResponse, new()
	{
		// Flag to check if Dispose has been called
		private bool _disposed = false;

		/// <summary>
		/// 
		/// </summary>
		protected readonly IUnitOfWork UnitOfWork;

		// Constructor to inject the UnitOfWork
		/// <summary>
		/// Constructor to inject the UnitOfWork
		/// </summary>
		protected BaseOperation(IUnitOfWork unitOfWork)
		{
			UnitOfWork = unitOfWork;
		}

		/// <summary>
		/// Abstract method that subclasses must implement 
		/// </summary>
		public TResponse Execute(TRequest request)
		{
			var response = new TResponse();
			try
			{
				var validationResponse = this.Validate(request);
				if (validationResponse)
				{
					response = this.ProcessAsync(request);
					this.Commit();
				}
				else
				{
					response.ErrorMessage = "Error while validating the request contract";
				}

				return response;
			}
			catch (Exception e)
			{
				response.ErrorMessage = e.ToString();
				return response;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public bool Validate(TRequest request)
		{
			return this.ValidateAsync(request);
		}

		/// <summary>
		/// Abstract method for validation, to be implemented by derived classes
		/// </summary>
		virtual protected bool ValidateAsync(TRequest request)
		{
			return true;
		}

		/// <summary>
		/// Abstract method for processing the entity, to be implemented by derived classes
		/// </summary>
		abstract protected TResponse ProcessAsync(TRequest request);

		/// <summary>
		/// Implement IDisposable
		/// </summary>
		public void Dispose()
		{
			// Dispose of managed resources
			Dispose(true);
			// Suppress finalization if Dispose is already called
			GC.SuppressFinalize(this);
		}

		// Protected method to dispose resources (managed/unmanaged)
		protected virtual void Dispose(bool disposing)
		{
			if (_disposed) return;

			if (disposing)
			{
				// Dispose managed resources here
				// Example: If _unitOfWork had any resources to clean up, dispose of them
				UnitOfWork?.Dispose();
			}

			// Dispose unmanaged resources here (if any)

			_disposed = true;
		}

		/// <summary>
		/// Common commit functionality
		/// </summary>
		protected void Commit()
		{
			UnitOfWork.Commit();
		}
	}
}