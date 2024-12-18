using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDbGenericRepository.Models;

namespace DotnetCore.Sample.Core.Entities.Abstraction
{
    /// <summary>
    /// 
    /// </summary>
	public class BaseEntity : Document
	{
        /// <summary>
        /// 
        /// </summary>
		public bool IsActive { get; set; }
	}
}