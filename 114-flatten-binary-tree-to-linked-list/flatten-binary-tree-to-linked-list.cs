/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    TreeNode last = null;
    public void Flatten(TreeNode root) {
        if(root != null)
        { 
            TreeNode curr = root;

            helper(curr);
        }  
    }
  
    public void helper(TreeNode node)
    {
        if(node.right != null)
        {
            helper(node.right);
        }

        if(node.left != null)
        {
            helper(node.left);
        }

        if(last != null)
        {
            node.left = null;
            node.right = last;
        }
        last = node;
    }
}