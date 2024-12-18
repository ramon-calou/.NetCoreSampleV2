using System;
using System.ComponentModel.DataAnnotations;

namespace DotnetCore.Sample.DataContract.Validations
{
	/// <summary>
	/// 
	/// </summary>
	public class GuidValidationAttribute : ValidationAttribute
	{
		public bool AllowEmptyGuid { get; set; } = false;

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			// Allow null or empty strings to pass if the property is optional
			if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
			{
				return ValidationResult.Success;
			}

			// Attempt to parse the value as a Guid
			if (!Guid.TryParse(value.ToString(), out Guid parsedGuid))
			{
				return new ValidationResult("The value is not a valid GUID.");
			}

			// Validate if empty GUIDs are allowed
			if (!AllowEmptyGuid && parsedGuid == Guid.Empty)
			{
				return new ValidationResult("The GUID cannot be empty.");
			}

			// Return success if validation passes
			return ValidationResult.Success;
		}
	}
}