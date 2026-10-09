namespace Atorie.Models;

// an entry in the popup's side panel: 
// a diary entry, an interpretation, the story behind a game feature, or an ARG writing
public class Note
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public required string Body { get; set; }
    public DateTime WrittenAt { get; set; }

    public int FileItemId { get; set; }
    public FileItem FileItem { get; set; } = null!;
}
