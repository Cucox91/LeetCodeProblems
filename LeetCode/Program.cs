using LeetCode;

Node root = new Node { val = 3 };

Node node5 = new Node { val = 5, parent = root };
Node node1 = new Node { val = 1, parent = root };

Node node6 = new Node { val = 6, parent = node5 };
node5.left = node6;
Node node2 = new Node { val = 2, parent = node5 };
node5.right = node2;

Node node0 = new Node { val = 0, parent = node1 };
node1.left = node0;
Node node8 = new Node { val = 8, parent = node1 };
node1.right = node8;

Node node7 = new Node { val = 7, parent = node2 };
node2.left = node7;
Node node4 = new Node { val = 4, parent = node2 };
node2.right = node4;


Solution s = new Solution();
s.LowestCommonAncestor(node5, node1);

public class Solution
{
    public Node LowestCommonAncestor(Node p, Node q)
    {
        // I will pick one of both. And start doing a search and marking with a dictionary.
        // If I cant find the element on a branch and childs, then I remove it from the dictionary.
        HashSet<int> visited = new HashSet<int>();
        Stack<Node> path = new Stack<Node>();
        path.Push(p);
        visited.Add(p.val);
        FindPath(visited, path, q);
        return q;
    }

    public bool FindPath(HashSet<int> visited, Stack<Node> path, Node q)
    {
        var current = path.Peek();
        visited.Add(current.val);
        if (current.val == q.val)
        {
            path.Push(current);
            return true;
        }

        if (current.left != null && !visited.Contains(current.left.val))
        {
            path.Push(current.left);
            var leftResult = FindPath(visited, path, q);
            if (leftResult) return true;
        }
        if (current.right != null && !visited.Contains(current.right.val))
        {
            path.Push(current.right);
            var rightResult = FindPath(visited, path, q);
            if (rightResult) return true;
        }

        if (current.parent != null && !visited.Contains(current.parent.val))
        {
            path.Push(current.parent);
            var parentReturn = FindPath(visited, path, q);
            if (parentReturn) return true;
        }
        else
        {
            path.Pop();
        }
        return false;
    }
}
