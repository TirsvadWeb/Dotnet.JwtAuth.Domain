using Microsoft.AspNetCore.Identity;

namespace TirsvadWeb.JwtAuth.Domain.Entities;

/// <summary>
/// Represents an application user with JWT authentication support.
/// Inherits from <see cref="IdentityUser"/> and adds properties for refresh token management.
/// </summary>
public class User : IdentityUser
{
    /// <summary>
    /// Gets or sets the refresh token associated with the user.
    /// </summary>
    public string? RefreshToken { get; set; }

    /// <summary>
    /// Gets or sets the expiry time of the refresh token.
    /// </summary>
    public DateTime? RefreshTokenExpiryTime { get; set; }
}
