using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
	public class IceCream
	{
		public IceCream(string iceCreamFlavour, int iceCreamCode)
		{
			IceCreamFlavour = iceCreamFlavour;
			IceCreamCode = iceCreamCode;
		}

		public string IceCreamFlavour { get; set; }

		public int IceCreamCode { get; set; }
	}
}
