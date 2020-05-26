 /*There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

You may assume nums1 and nums2 cannot be both empty.

Example 1:

nums1 = [1, 3]
nums2 = [2]

The median is 2.0
Example 2:

nums1 = [1, 2]
nums2 = [3, 4]

The median is (2 + 3)/2 = 2.5*/
 
 public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length < nums2.Length) return FindMedianSortedArrays(nums2, nums1);

            if (nums1 == null || nums1.Length <= 0) return FindMedian(nums2);

            if (nums2 == null || nums2.Length <= 0) return FindMedian(nums1);

            /*
                m = num1.length , n = num2.length
                k = (m + n) / 2;
                本题转换为寻找两个数组第 k 小的数
                1. 奇数情况
                    1.1 初始化两个变量指向两个数组中间 i = m / 2; j = n / 2;
                    1.2 A[i] <= B[j] 则A[i]前面的数字都可以丢弃，这时候变成求A[i] ~ A[n] 和 B[0] ~ B[n]两个数组第（k - i -1)小的数
                    1.3 A[i] > B[j] 则B[j]前面的数字都可以丢弃，这时候变成求A[0] ~ A[n] 和 B[j] ~ B[n]两个数组第（k - j - 1)小的数
                    1.4 以此类推
                    1.5 k == 0，当前两个数组第一个数小的那个就是中位数
                    1.6 注意边界问题，数组长度为空或1，跳出递归的条件
                2. 偶数情况
                    ((k - 1) + k) /2
            */
            var len = nums1.Length + nums2.Length;
        
            if (len % 2 == 1) return FindMedianSortedArrays(nums1, 0, nums1.Length, nums2, 0, nums2.Length, len / 2);

            return (FindMedianSortedArrays(nums1, 0, nums1.Length, nums2, 0, nums2.Length, len / 2 - 1) + FindMedianSortedArrays(nums1, 0, nums1.Length, nums2, 0, nums2.Length, len / 2)) / 2.0d;
        }

        public double FindMedianSortedArrays(int[] nums1, int start1, int end1, int[] nums2, int start2, int end2, int k)
        {
            //保证长的数组在前
            if ((end1 - start1) < (end2 - start2)) return FindMedianSortedArrays(nums2, start2, end2, nums1, start1, end1, k);

            if (k == 0) return Math.Min(nums1[start1], nums2[start2]);

            if ((end1 - start1) <= 1) return Math.Max(nums1[start1], nums2[start2]); //第一个数组长度为1的情况

            if ((end2 - start2) <= 1)   //第二数组长度为1的情况
            {
                if (nums1[start1 + k] <= nums2[start2]) return nums1[start1 + k];

                return Math.Max(nums1[start1 + k - 1], nums2[start2]);
            }
            if (k == 1) //k == 1，即第二小的数字，比较两组数组前面2个元素即可得到结果
            {
                if (nums1[start1 + 1] <= nums2[start2]) return nums1[start1 + 1];

                if (nums1[start1] >= nums2[start2 + 1]) return nums2[start2 + 1];

                return Math.Max(nums1[start1], nums2[start2]);
            }

            var i = Math.Min((end1 - start1), k) / 2;
            var j = Math.Min((end2 - start2), k) / 2;

            if (nums1[start1 + i] < nums2[start2 + j]) return FindMedianSortedArrays(nums1, start1 + i, end1, nums2, start2, end2, k - i);

            return FindMedianSortedArrays(nums1, start1, end1, nums2, start2 + j, end2, k - j);
        }

        public double FindMedian(int[] nums)
        {
            if (nums == null || nums.Length <= 0) throw new Exception("no result");

            if (nums.Length % 2 == 0) return (nums[nums.Length / 2 - 1] + nums[nums.Length / 2]) / 2.0d; ;

            return nums[nums.Length / 2];
        }
