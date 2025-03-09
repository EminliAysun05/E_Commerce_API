using ECommerce.Application.Bases;
using ECommerce.Application.Features.Products.Exceptions;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Products.Rules
{
	public class ProductRules : BaseRules
	{
		public Task ProductTitleMustBeUnique(IList<Product> products, string requestTitle )
		{
			if(products.Any(x=>x.Title == requestTitle))
				throw new ProductTitleMustBeUniqueException();
			
			return Task.CompletedTask;
		}
	}
}
