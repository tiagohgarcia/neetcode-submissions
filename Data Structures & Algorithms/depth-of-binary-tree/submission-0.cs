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
    public int MaxDepth(TreeNode root) {
        if(root is null) return 0;
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int levels = 0;

        while(q.Count > 0) {
            levels++;
            int nodes = q.Count;
            for(int i = 0; i < nodes; i++) {
                TreeNode node = q.Dequeue();
                if(node.left is not null) q.Enqueue(node.left);
                if(node.right is not null) q.Enqueue(node.right);
            }
        }

        return levels;
    }
}
