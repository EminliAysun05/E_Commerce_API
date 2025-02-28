using ECommerce.Application.Repositories.Interfaces;
using ECommerce.Application.Repositories.UnitOfWorks;
using ECommerce.Persistance.Context;
using ECommerce.Persistance.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistance.UnitOfWorks
{
	public class UnitOfWork : IUnitOfWork
	{

		private readonly AppDbContext dbContext;

		public UnitOfWork(AppDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

	

		public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();


		public int Save() => dbContext.SaveChanges();

		public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();



		IReadRepository<T> IUnitOfWork.GetReadRepoitory<T>() => new ReadRepository<T>(dbContext);

		IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);
	}
}
