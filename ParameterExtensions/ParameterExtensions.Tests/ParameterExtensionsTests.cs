using System;
using NUnit.Framework;

namespace ParameterExtensions.Tests
{
	[TestFixture]
	public class ParameterExtensionsTests
	{
		[Test]
		public void Should_throw_argument_null_exception_when_value_is_null()
		{
			Assert.Throws<ArgumentNullException>(() => ParameterExtensions.ThrowIfNull(null, "paramName"));
		}

		[Test]
		public void Should_throw_argument_null_exception_when_string_value_is_empty()
		{
			Assert.Throws<ArgumentNullException>(() => ParameterExtensions.ThrowIfNullOrEmpty(string.Empty, "paramName"));
		}

		[Test]
		public void Should_throw_argument_null_exception_when_string_value_is_null()
		{
			Assert.Throws<ArgumentNullException>(() => ParameterExtensions.ThrowIfNullOrEmpty(null, "paramName"));
		}
	}
}
