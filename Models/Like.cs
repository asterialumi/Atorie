namespace Atorie.Models;

// one like from one visitor
// VisitorId is an anonymous token, so the same visitor can't like the same file twice
public class Like
{
    public int Id { get; set; }
    public required string VisitorId { get; set; }
    public DateTime LikedAt { get; set; }

    public int FileItemId { get; set; }
    public FileItem FileItem { get; set; } = null!;
}
