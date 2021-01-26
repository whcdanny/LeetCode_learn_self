public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        int sum = 0;
        while (left < right)
        {
            sum = numbers[left] + numbers[right];
            if (sum == target)
                return new int[] { left+1, right+1 };
            else if (sum < target)
                left++;
            else
                right--;
        }
        return new int[] { };
    }
}

//C++
class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        int left=0;
        int right=numbers.size()-1;
        int sum=0;
        while(left<right){
            sum=numbers[left]+numbers[right];
            if(sum==target){
                return {(left+1), (right+1)};
            }
            else if(sum<target){
                left++;
            }
            else{
                right--;
            }
        }
        return {};
    }
};