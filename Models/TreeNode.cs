namespace Atorie.Models;

public enum NodeKind
{
    Folder,
    Image,
    Text,
    Executable
}

public class TreeNode
{
    public required string Name { get; init; }
    public required NodeKind Kind { get; init; }
    public List<TreeNode> Children { get; init; } = new();

    // ordinary files ignore this
    public bool IsExpanded { get; set; }

    public bool IsFolder => Kind == NodeKind.Folder;
}
