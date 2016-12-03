using System;

namespace ParameterExtensions
{
	public static class ParameterExtensions
	{
		public static void ThrowIfNull(this object value, string parameterName)
		{
			if (value == null)
				throw new ArgumentNullException(parameterName);
		}

		public static void ThrowIfNullOrEmpty(this string value, string parameterName)
		{
			if (string.IsNullOrEmpty(value))
				throw new ArgumentNullException(parameterName);
		}
	}
}
