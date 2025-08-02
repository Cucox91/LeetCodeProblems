namespace LeetCode;

public class TreeNode
{
    public int val { get; set; }

    public TreeNode? left { get; set; }
    public TreeNode? right { get; set; }
    public TreeNode? parent { get; set; }

    public TreeNode()
    {
        
    }

    public TreeNode(int val, TreeNode? left, TreeNode? right)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public TreeNode(int val, TreeNode? left, TreeNode? right, TreeNode? parent)
    {
        this.val = val;
        this.left = left;
        this.right = right;
        this.parent = parent;
    }
}