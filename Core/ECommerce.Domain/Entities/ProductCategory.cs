﻿using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
	public class ProductCategory : IEntityBase
	{
        public int ProductId { get; set; }
		public Product Product { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
