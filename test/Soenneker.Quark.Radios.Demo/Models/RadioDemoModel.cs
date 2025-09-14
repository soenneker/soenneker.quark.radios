using System.ComponentModel.DataAnnotations;

namespace Soenneker.Quark.Radios.Demo.Models;

public class RadioDemoModel
{
    [Required(ErrorMessage = "Please select a preference")]
    public string? Preference { get; set; }

    [Required(ErrorMessage = "Please select a subscription plan")]
    public string? SubscriptionPlan { get; set; }

    [Required(ErrorMessage = "Please select your experience level")]
    public string? ExperienceLevel { get; set; }

    public bool AgreeToTerms { get; set; }

    [Required(ErrorMessage = "Please select a notification preference")]
    public string? NotificationPreference { get; set; }
}

public enum PreferenceType
{
    Option1,
    Option2,
    Option3
}

public enum SubscriptionPlan
{
    Free,
    Basic,
    Premium,
    Enterprise
}

public enum ExperienceLevel
{
    Beginner,
    Intermediate,
    Advanced,
    Expert
}

public enum NotificationPreference
{
    Email,
    SMS,
    Push,
    None
}
