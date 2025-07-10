using TirsvadWeb.JwtAuth.Domain.Validation;

namespace TirsvadWeb.JwtAuth.Domain.Entities;

/// <summary>
/// Represents an application user with JWT authentication support.
/// </summary>
public class ApplicationUser
{
    /// <summary>
    /// Gets or sets the unique identifier for the user.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the username of the user.
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the hashed password of the user.
    /// </summary>
    public string PasswordHash { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the role of the user.
    /// </summary>
    public string Role { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the refresh token associated with the user.
    /// The token must be a Base64-encoded string of length 32.
    /// </summary>
    [RefreshTokenBase64Length(32)]
    public string? RefreshToken { get; set; }

    /// <summary>
    /// Gets or sets the expiry time of the refresh token.
    /// </summary>
    public DateTime? RefreshTokenExpiryTime { get; set; }
}