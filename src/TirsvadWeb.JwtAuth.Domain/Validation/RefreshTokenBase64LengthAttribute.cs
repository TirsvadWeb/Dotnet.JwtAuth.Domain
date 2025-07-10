using System.ComponentModel.DataAnnotations;

namespace TirsvadWeb.JwtAuth.Domain.Validation;

/// <summary>
/// Validation attribute to ensure a string property is a valid base64-encoded value
/// that decodes to exactly the specified number of bytes.
/// </summary>
internal class RefreshTokenBase64LengthAttribute : ValidationAttribute
{
    private readonly int _expectedLength;

    /// <summary>
    /// Initializes a new instance of the <see cref="RefreshTokenBase64LengthAttribute"/> class.
    /// </summary>
    /// <param name="expectedLength">The required length in bytes of the decoded base64 string.</param>
    public RefreshTokenBase64LengthAttribute(int expectedLength)
    {
        _expectedLength = expectedLength;
        ErrorMessage = string.Format(ErrorMessages.RefreshTokenBase64Length, _expectedLength);
    }

    /// <summary>
    /// Determines whether the specified value is a valid base64 string of the expected byte length.
    /// </summary>
    /// <param name="value">The value of the property to validate.</param>
    /// <returns>
    /// <c>true</c> if the value is null or a base64 string that decodes to the expected length; otherwise, <c>false</c>.
    /// </returns>
    public override bool IsValid(object? value)
    {
        if (value is null)
            return true;

        if (value is string s)
        {
            try
            {
                var bytes = Convert.FromBase64String(s);
                return bytes.Length == _expectedLength;
            }
            catch
            {
                return false;
            }
        }
        return false;
    }
}