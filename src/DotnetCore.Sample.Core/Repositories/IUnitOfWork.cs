namespace DotnetCore.Sample.Core.Repositories
{
	/// <summary>
	/// 
	/// </summary>
	public interface IUnitOfWork : IDisposable
	{
		/// <summary>
		/// 
		/// </summary>
		IRestaurantRepository RestaurantRepository { get; }

		/// <summary>
		/// 
		/// </summary>
		IUserRespository UserRepository { get; }

		/// <summary>
		/// 
		/// </summary>
		void Commit();
	}
}