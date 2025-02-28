using ECommerce.Application.Repositories.Interfaces;
using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Repositories.UnitOfWorks
{
	public interface IUnitOfWork : IAsyncDisposable 
	{
		IReadRepository<T> GetReadRepoitory<T>() where T : class, IEntityBase, new();
		IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();
		Task<int> SaveAsync();
		int Save();
	}
}
