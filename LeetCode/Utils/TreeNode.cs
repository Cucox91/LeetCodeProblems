namespace LeetCode;

public class Node
{
    public int val { get; set; }

    public Node? left { get; set; }
    public Node? right { get; set; }
    public Node? parent { get; set; }

    public Node()
    {
        
    }

    public Node(int val, Node? left, Node? right)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public Node(int val, Node? left, Node? right, Node? parent)
    {
        this.val = val;
        this.left = left;
        this.right = right;
        this.parent = parent;
    }
}