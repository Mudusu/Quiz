using Microsoft.AspNetCore.Identity;

namespace Quiz.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string ProfilePicture { get; set; } = string.Empty;
}

