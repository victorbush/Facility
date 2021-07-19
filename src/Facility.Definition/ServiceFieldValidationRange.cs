using System;

namespace Facility.Definition
{
	/// <summary>
	/// A range for validating numeric values
	/// </summary>
	public sealed class ServiceFieldValidationRange
	{
		/// <summary>
		/// Creates a range for validation.
		/// </summary>
		/// <param name="minimum">The inclusive start of the range</param>
		/// <param name="maximum">The inclusive end of the range</param>
		public ServiceFieldValidationRange(decimal? minimum, decimal? maximum)
		{
			if (minimum == null && maximum == null)
				throw new ArgumentException($"{nameof(minimum)} or {nameof(maximum)} must be specified");

			Minimum = minimum;
			Maximum = maximum;
		}

		/// <summary>
		/// The minimum allowed value, inclusive.
		/// </summary>
		public decimal? Minimum { get; }

		/// <summary>
		/// The maximum allowed value, inclusive.
		/// </summary>
		public decimal? Maximum { get; }
	}
}
