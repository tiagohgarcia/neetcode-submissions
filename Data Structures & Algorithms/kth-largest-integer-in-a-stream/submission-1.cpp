class KthLargest {
private:
    priority_queue<int, vector<int>, greater<int>> minHeap;
    int k = 0;
public:
    KthLargest(int k, vector<int>& nums) : k(k) {
        for(int n : nums) add(n);
    }
    
    int add(int val) {
        minHeap.push(val);
        if(minHeap.size() > k) minHeap.pop();
        return minHeap.top();
    }
};
