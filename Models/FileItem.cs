namespace Atorie.Models;

// a piece of work or content: an illustration, a piece of writing, a game
// its spot on the canvas is the folder's center plus a small manual nudge
public class FileItem
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public FileKind Kind { get; set; }
    public string? Description { get; set; }
    public DateOnly CreatedOn { get; set; }


    public string? ContentUrl { get; set; }
    public string? TextContent { get; set; }

    public int OffsetX { get; set; }
    public int OffsetY { get; set; }

    public int ViewCount { get; set; }

    public int FolderId { get; set; }
    public Folder Folder { get; set; } = null!;

    public List<Note> Notes { get; set; } = new();
    public List<Like> Likes { get; set; } = new();

    // computed from likes, not stored
    public int LikeCount => Likes.Count;
}
