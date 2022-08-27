using System;
using System.Collections.Generic;
using Exercises.Models;
namespace Exercises
{
	public class Exercise003
	{
        public string[] IceCreamFlavours(List<IceCream> icecreams)
		{
            //Console.WriteLine(icecreams.Count);
            string[] iceCreamFlavour = new string[icecreams.Count];
			int i = 0;
            foreach (var ice in icecreams)
                iceCreamFlavour[i++] = ice.IceCreamFlavour;
            return iceCreamFlavour;

        }

         public int IceCreamCode(string iceCreamFlavour, List<IceCream> icecreams)
        {
            int iceCreamCode = 0;
            foreach (var ice in icecreams)
            {
                if (ice.IceCreamFlavour.Equals(iceCreamFlavour))
                    iceCreamCode = ice.IceCreamCode;
                    
            }
            return iceCreamCode;
        }

        public int IceCreamCode(string iceCreamFlavour)
		{
            if (iceCreamFlavour.Equals("Mint Chocolate Chip"))
				return 3;
			else if (iceCreamFlavour.Equals("Mango Sorbet"))
				return 5;
			else if (iceCreamFlavour.Equals("Raspberry Ripple"))
				return 1;
			else
				return 0;
		}

	}
}
