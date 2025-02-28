using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
	public class Product : EntityBase
	{
		public Product()
		{

		}
		public Product(string title, string description, int brandId, int price, int discount)
		{
			title = Title;
			description = Description;
			brandId = BrandId;
			price = Price;
			discount = Discount;
		}
        public string Title { get; set; }
		public  string Description { get; set; }
		public  int BrandId { get; set; }
		public Brand Brand { get; set; } 
        public int Price { get; set; }
        public int Discount { get; set; }
		//public required string ImagePath { get; set; }
		public ICollection<Category> Categories { get; set; }

    }
}
