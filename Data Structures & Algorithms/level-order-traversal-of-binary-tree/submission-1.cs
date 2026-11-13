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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        if(root is null) return result;
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0) {
            int count = q.Count;
            var level = new List<int>();

            for(int i = 0; i < count; i++) {
                TreeNode current = q.Dequeue();
                level.Add(current.val); // add to list

                // add children to queue
                if(current.left is not null) q.Enqueue(current.left);
                if(current.right is not null) q.Enqueue(current.right);
            }

            result.Add(level);
        }

        return result;
    }
}
