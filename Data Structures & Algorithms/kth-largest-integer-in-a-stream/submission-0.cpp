class KthLargest {
private:
    priority_queue<int, vector<int>, greater<int>> minHeap;
    int kth = 0;
public:
    KthLargest(int k, vector<int>& nums) {
        kth = k;
        for(int i = 0; i < nums.size(); i++) {
            minHeap.push(nums[i]);
        }
    }
    
    int add(int val) {
        minHeap.push(val);
        
        auto temp = minHeap;
        int skip = temp.size() - kth;
        for(int i = 0; i < skip; i++) {
            temp.pop();
        }
        return temp.top();
    }
};
