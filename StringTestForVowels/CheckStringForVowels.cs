using System;
using System.Linq;
using NUnit;
using NUnit.Framework;

namespace StringTestForVowels
{
	[TestFixture]
	public class VowelsInAString
	{
		[Test]
		public void GivenString_ThatHasVowels_ShouldReturn5()
		{
			//arrange	
			var vowelTest = "abracadabra";

			//act
			var expected = 5;
			var actual = CheckForVowelsInString(vowelTest);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void GivenString_ThatHasNoVowels_ShouldReturn0()
		{
			//arrange	
			var vowelTest = "klfg";

			//act
			var expected = 0;
			var actual = CheckForVowelsInString(vowelTest);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void GivenString_ThatHasMultipleVowels_ShouldReturnNumber()
		{
			//arrange	
			var vowelTest = "Merry Christmas to you my friend";

			//act
			var expected = 8;
			var actual = CheckForVowelsInString(vowelTest);

			//assert
			Assert.AreEqual(expected, actual);
		}

		private int CheckForVowelsInString(string vowelTest)
		{
			return vowelTest.Count(v => "aeiou".Contains(v)); 
		}
	}
}
