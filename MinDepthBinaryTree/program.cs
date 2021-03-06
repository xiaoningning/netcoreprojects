/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        int left = MinDepth(root.left);
        int right = MinDepth(root.right);
        return (root.left == null || root.right == null) ? 
            left + right + 1 : Math.Min(left, right) + 1;
    }
}
