﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerce.Application.Exceptions
{
	public class ExceptionModel : ErrorStatusCodes
	{
		public IEnumerable<string> Errors { get; set; }
		public override string ToString()
		{
			return JsonSerializer.Serialize(this);
		}


	}

	public class ErrorStatusCodes
	{
		public int StatusCodes { get; set; }

	}


}
