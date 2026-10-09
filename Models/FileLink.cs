namespace Atorie.Models;

// a line drawn between two nodes on the canvas (notes.txt -> painting.png).
public class FileLink
{
    public int Id { get; set; }

    public int FromFileItemId { get; set; }
    public FileItem FromFileItem { get; set; } = null!;

    public int ToFileItemId { get; set; }
    public FileItem ToFileItem { get; set; } = null!;
}
