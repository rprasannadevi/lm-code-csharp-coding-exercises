using NUnit.Framework;
using FluentAssertions;
using Exercises.Models;
using System.Collections.Generic;

namespace Exercises.Tests
{
    public class Exercise003Tests
    {
        private Exercise003 Exercise003;

        [SetUp]
        public void Setup()
        {
            Exercise003 = new Exercise003();
        }

        [Test]
        public void Given_Chocolate_Chip_GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {
			
			string iceCreamFlavour = "Mint Chocolate Chip";
            int expectedCode = 3;

            Exercise003.IceCreamCode(iceCreamFlavour).Should().Be(expectedCode);
        }

        [Test]
        public void Given_Mango_Sorbet_GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {
            string iceCreamFlavour = "Mango Sorbet";
            int expectedCode = 5;

            Exercise003.IceCreamCode(iceCreamFlavour).Should().Be(expectedCode);
        }

        [Test]
        public void Given_Raspberry_Ripple_GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {
            string iceCreamFlavour = "Raspberry Ripple";
            int expectedCode = 1;

            Exercise003.IceCreamCode(iceCreamFlavour).Should().Be(expectedCode);

        }

        [Test]
        public void GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {

            IceCream c1 = new("Pistachio", 0);
            IceCream c2 = new("Raspberry Ripple", 1);
            IceCream c3 = new("Vanilla", 2);
            IceCream c4 = new("Mint Chocolate Chip", 3);
            IceCream c5 = new("Chocolate", 4);
            IceCream c6 = new("Mango Sorbet", 5);

            var icecreams = new List<IceCream>
            {
                c1,
                c2,
                c3,
                c4,
                c5,
                c6
            };

            Exercise003.IceCreamCode("Mint Chocolate Chip", icecreams).Should().Be(3);
            Exercise003.IceCreamCode("Mango Sorbet", icecreams).Should().Be(5);
            Exercise003.IceCreamCode("Raspberry Ripple", icecreams).Should().Be(1);
            Exercise003.IceCreamCode("Pistachio", icecreams).Should().Be(0);
            Exercise003.IceCreamCode("Vanilla", icecreams).Should().Be(2);
            Exercise003.IceCreamCode("Chocolate", icecreams).Should().Be(4);
        }

        [Test]
        public void Ice_Cream_Flavours_Should_Return_All_Flavours()
        {
            string[] expected = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

            IceCream c1 = new("Pistachio", 0);
            IceCream c2 = new("Raspberry Ripple", 1);
            IceCream c3 = new("Vanilla", 2);
            IceCream c4 = new("Mint Chocolate Chip", 3);
            IceCream c5 = new("Chocolate", 4);
            IceCream c6 = new("Mango Sorbet", 5);

            var icecreams = new List<IceCream>
            {
                c1,
                c2,
                c3,
                c4,
                c5,
                c6
            };

            //Exercise003.IceCreamFlavours.Should().Equal(expected);
            Exercise003.IceCreamFlavours(icecreams).Should().Equal(expected);
        }
    }
}
