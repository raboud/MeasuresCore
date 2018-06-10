using RandREng.Types;
using System;
using Xunit;

namespace Types.Test
{
    public class PhoneNumber10ExtTest
    {
		// #|ext\.?|extension|x
		[Theory]
		[InlineData("(404) 991-9375")]
		[InlineData("(404)991-9375")]
		[InlineData("404.991.9375")]
		[InlineData("404-991-9375")]
		[InlineData("4049919375")]
		[InlineData("(404) 991-9375x1234")]
		[InlineData("(404)991-9375 #12345")]
		[InlineData("404.991.9375 #12345")]
		[InlineData("404-991-9375 #12345")]
		[InlineData("4049919375 #12345")]
		public void TestPass(string a)
		{
			PhoneNumber10Ext pn = new PhoneNumber10Ext();
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
			PhoneNumber10Ext pn = new PhoneNumber10Ext();
			Assert.False(pn.IsValid(a));

		}
	}
}
