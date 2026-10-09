namespace Atorie.Models;

// the "logged in as" card, there is only ever one row.
public class Profile
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public string? AvatarUrl { get; set; }
    public DateOnly Registered { get; set; }
    public required string Address { get; set; }

    // shows up as "logged since: N days ago"
    public int DaysSinceRegistered =>
        DateOnly.FromDateTime(DateTime.Today).DayNumber - Registered.DayNumber;
}
