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
        if(root is null) return [];
        
        List<List<int>> result = new List<List<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int level = 0;
        int count = 1;

        while(count > 0) {
            result.Add(new List<int>());
            for(int i = 0; i < count; i++) {
                TreeNode current = q.Dequeue();
                result[level].Add(current.val); // add to list

                // add children to queue
                if(current.left is not null) q.Enqueue(current.left);
                if(current.right is not null) q.Enqueue(current.right);
            }
            level++;
            count = q.Count();
        }

        return result;
    }
}
