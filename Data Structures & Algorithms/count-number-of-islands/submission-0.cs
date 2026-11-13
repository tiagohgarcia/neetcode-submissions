public class Solution {
    public void Search(char[][] grid, int i, int j) {
        if(i < 0 || grid.Length <= i) return;       // ut of bounds
        if(j < 0 || grid[i].Length <= j) return;    // out of bounds
        if(grid[i][j] == '0') return;               // already zero

        // it is '1'
        grid[i][j] = '0'; // set to 0 to avoid infinite recursion
        
        // search vertically and horizontally
        Search(grid, i - 1, j);
        Search(grid, i + 1, j);
        Search(grid, i, j - 1);
        Search(grid, i, j + 1);
    }
    
    public int NumIslands(char[][] grid) {
        int count = 0;

        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == '1') { //found an island
                    Search(grid, i, j);
                    count++;
                }
            }
        }

        return count;
    }   
}
