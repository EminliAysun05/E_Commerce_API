﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Features.Products.Commands.DeleteProduct
{
	public class DeleteCommandProductRequest : IRequest
	{
        public int Id { get; set; }
    }
}
