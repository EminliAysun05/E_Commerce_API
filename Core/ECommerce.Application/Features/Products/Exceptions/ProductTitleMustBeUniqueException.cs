using ECommerce.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Products.Exceptions
{
	public class ProductTitleMustBeUniqueException : BaseExceptions
	{
        public ProductTitleMustBeUniqueException() : base("This product title is already exist...")
        {
        }
    }
}
