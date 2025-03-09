﻿using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Repositories.Interfaces.AutoMapper
{
	public interface IMapper
	{
		TDestination Map<TDestination, TSource>(TSource source, string? ignore = null);
		IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null);

		TDestination Map<TDestination>(object source, string? ignore = null);
		IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null);

	}
	
}
