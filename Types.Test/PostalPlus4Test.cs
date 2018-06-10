using RandREng.Types;
using System;
using Xunit;

namespace Types.Test
{
    public class PostalPlus4Test
    {
		[Theory]
		[InlineData("12345-1234")]
		[InlineData("12345")]
		public void TestPass(string a)
		{
			PostalPlus4 pn = new PostalPlus4();
			Assert.True(pn.IsValid(a));

		}
		[Theory]
		[InlineData("1235-1234")]
		[InlineData("12345-134")]
		[InlineData("1234")]
		[InlineData("123456")]
		[InlineData("123456789")]
		public void TestFail(string a)
		{
			PostalPlus4 pn = new PostalPlus4();
			Assert.False(pn.IsValid(a));

		}
	}
}
