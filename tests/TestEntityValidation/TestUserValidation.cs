using System.ComponentModel.DataAnnotations;
using TirsvadWeb.JwtAuth.Domain.Entities;

namespace TestEntityValidation;

[TestClass]
public sealed class TestUserValidation
{
    [TestMethod]
    public void User_RefreshToken_ValidBase64Length32_ShouldBeValid()
    {
        // Arrange
        var user = new ApplicationUser
        {
            RefreshToken = Convert.ToBase64String(new byte[32])
        };

        var context = new ValidationContext(user) { MemberName = nameof(ApplicationUser.RefreshToken) };
        var results = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateProperty(user.RefreshToken, context, results);

        // Assert
        Assert.IsTrue(isValid, "RefreshToken with valid base64 32 bytes should be valid.");
    }

    [TestMethod]
    public void User_RefreshToken_InvalidBase64_ShouldBeInvalid()
    {
        // Arrange
        var user = new ApplicationUser
        {
            RefreshToken = "not_base64!"
        };

        var context = new ValidationContext(user) { MemberName = nameof(ApplicationUser.RefreshToken) };
        var results = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateProperty(user.RefreshToken, context, results);

        // Assert
        Assert.IsFalse(isValid, "RefreshToken with invalid base64 should be invalid.");
    }

    [TestMethod]
    public void User_RefreshToken_Base64WrongLength_ShouldBeInvalid()
    {
        // Arrange
        var user = new ApplicationUser
        {
            RefreshToken = Convert.ToBase64String(new byte[16]) // Only 16 bytes
        };

        var context = new ValidationContext(user) { MemberName = nameof(ApplicationUser.RefreshToken) };
        var results = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateProperty(user.RefreshToken, context, results);

        // Assert
        Assert.IsFalse(isValid, "RefreshToken with base64 not 32 bytes should be invalid.");
    }

    [TestMethod]
    public void User_RefreshToken_Null_ShouldBeValid()
    {
        // Arrange
        var user = new ApplicationUser
        {
            RefreshToken = null
        };

        var context = new ValidationContext(user) { MemberName = nameof(ApplicationUser.RefreshToken) };
        var results = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateProperty(user.RefreshToken, context, results);

        // Assert
        Assert.IsTrue(isValid, "Null RefreshToken should be valid (unless [Required] is used).");
    }
}