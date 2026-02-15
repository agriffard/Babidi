using System.ComponentModel.DataAnnotations;

namespace Babidi.Dashboard.Models;

public class ProfileModel
{
    [Required]
    public string FullName { get; set; } = "Demo User";

    [Required]
    [EmailAddress]
    public string Email { get; set; } = "demo@babidi.app";

    public bool NotificationsEnabled { get; set; } = true;
}
