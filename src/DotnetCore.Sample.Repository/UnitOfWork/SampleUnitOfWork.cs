// using DotnetCore.Sample.Core.Repositories;

using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.Core.Settings;
using DotnetCore.Sample.Repository.Repositories;
using MongoDB.Driver;

namespace DotnetCore.Sample.Repository.UnitOfWork
{
	/// <summary>
	/// 
	/// </summary>
	public class SampleUnitOfWork : IUnitOfWork
	{
		/// <summary>
		/// 
		/// </summary>
		private readonly IMongoDatabase _sampleRepository;

		/// <summary>
		/// 
		/// </summary>
		private IRestaurantRepository _restaurantsRepository;

		/// <summary>
		/// 
		/// </summary>
		private IUserRespository _userRepository;

		/// <summary>
		/// 
		/// </summary>
		public IRestaurantRepository RestaurantRepository => _restaurantsRepository ??= new RestaurantRepository(_sampleRepository);

		/// <summary>
		/// 
		/// </summary>
		public IUserRespository UserRepository => _userRepository ??= new UserRepository(_sampleRepository);

		/// <summary>
		/// 
		/// </summary>
		public SampleUnitOfWork(ISettings settings)
		{
			MongoClient client = new MongoClient(settings.ConnectionString);

			if (!string.IsNullOrEmpty(settings.SampleDatabaseName))
			{
				_sampleRepository = client.GetDatabase(settings.SampleDatabaseName);
			}
		}

		public void Commit()
		{
		}

		public void Dispose()
		{
		}
	}
}