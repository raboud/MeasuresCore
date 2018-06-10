using RandREng.Types;
using System;
using Xunit;

namespace Types.Test
{
    public class PhoneTest
    {
        [Theory]
		[InlineData("(404) 991-9375")]
		[InlineData("(404)991-9375")]
		[InlineData("404.991.9375")]
		[InlineData("404-991-9375")]
		[InlineData("4049919375")]
		public void TestPass(string a)
        {
			PhoneNumber10 pn = new PhoneNumber10();
			Assert.True(pn.IsValid(a));

		}
		[Theory]
		[InlineData("(40) 991-9375")]
		[InlineData("(40)991-9375")]
		[InlineData("40.991.9375")]
		[InlineData("40-991-9375")]
		[InlineData("409919375")]
		[InlineData("(404) 91-9375")]
		[InlineData("(404)91-9375")]
		[InlineData("404.91.9375")]
		[InlineData("404-91-9375")]
		public void TestFail(string a)
		{
			PhoneNumber10 pn = new PhoneNumber10();
			Assert.False(pn.IsValid(a));

		}
	}
}
