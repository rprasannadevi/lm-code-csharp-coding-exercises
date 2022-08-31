using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            string sFlcWord="";
			if (String.IsNullOrEmpty(word))
                sFlcWord = word;
			else if (word.Length == 1)
                sFlcWord = char.ToString(char.ToUpper(word[0]));
            else
				sFlcWord = char.ToString(char.ToUpper(word[0])) + word.Substring(1);
            
            return sFlcWord;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            string sInitials = "";
            if (firstName != null && lastName != null)
                sInitials = char.ToString(char.ToUpper(firstName[0])) + "." + char.ToString(char.ToUpper(lastName[0]));
                //Console.WriteLine(sInitials);
            return sInitials;
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0)
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            else if(vatRate <0)
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");

			return originalPrice + Math.Round(((originalPrice * vatRate) / 100), 2);
		}

        public string Reverse(string sentence)
        {
            string reverseString = "";
			
            if (String.IsNullOrEmpty(sentence))
                reverseString = sentence;
            else if (sentence.Length > 0)
            {
				var sentenceLength = sentence.Length - 1;
				for (int i = sentenceLength; i >= 0; i--)
                    reverseString = reverseString + sentence.Substring(i, 1);
				
            }
            //Console.WriteLine(reverseString);
			return reverseString;
        }

        public int CountLinuxUsers(List<User> users)
        {
            if (users != null)
            {
                var iCountLinuxUsers = from n in users
                                       where n.Type == "Linux"
                                       select n;
                //Console.WriteLine(iCountLinuxUsers.Count());
                return iCountLinuxUsers.Count();
            }
            else
                return 0;

            /*var iCountLinuxUsers = 0;
            if(users != null)
            {
                foreach (var user in users)
                {
                    if (user.Type.Equals("Linux"))
                        iCountLinuxUsers = iCountLinuxUsers + 1;
			    }
            }
            //Console.WriteLine(iCountLinuxUsers);
            return iCountLinuxUsers;*/
        }
    }
}
