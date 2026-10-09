namespace Atorie.Models;

// a chapter in the file tree, folders can contain other folders
// CanvasX/CanvasY is the center of this folder's cluster on the canvas
public class Folder
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public int CanvasX { get; set; }
    public int CanvasY { get; set; }

    public int? ParentFolderId { get; set; }
    public Folder? ParentFolder { get; set; }

    public List<Folder> SubFolders { get; set; } = new();
    public List<FileItem> Files { get; set; } = new();
}
