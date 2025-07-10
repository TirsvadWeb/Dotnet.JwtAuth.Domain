namespace TirsvadWeb.JwtAuth.Domain;

internal class ErrorMessages
{
    /// <summary>
    /// Message format for refresh token base64 length validation.
    /// </summary>
    public const string RefreshTokenBase64Length = "RefreshToken must be a base64 string representing exactly {0} bytes.";
}
