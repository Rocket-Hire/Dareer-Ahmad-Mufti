//Task 1
// A phrase is a palindrome if it reads the same forward and backward.

// Given a string s, return true if it is a palindrome, or false otherwise.

 
//

// Example 1:

// Input: s = "pananap”
// Output: true
// Explanation: "pananap" is a palindrome.
// Example 2:

// Input: s = "raceacar"+
// Output: false
// Explanation: "raceacar" is not a palindrome.

public bool IsPalindrome(string s)
{
  int len = (int) s.length /2;
  for(int i = 0; i < len; i++) {

    if(s[i] != s[s.length-1 - i])
      return false;
  }

  return true;
}


//Task 2
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

 

// Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]

int target = 9;
int[] x = new int[4] {2,7,11,15};

// O(|nlogn| + |logN|)




public int[] GetIndexes(int[] arr, int target){
  for (int i = 0 ; i < arr.Length -1 ; i++) {
    int diff = target - arr[i];
    for(int j = i+1; j <= arr.Length; j++) {
      if(diff == arr[j]){
        return new int[] {i, j};
      }
    }
  }
  
  return new int[0];
}

//Dictionary optimisation
Dictionary<int, int> d = new Dictionary<int, int>();
for(int i = 0 ; x < arr.Length; i++) {
    int diff = target - arr[i];
  if(d.hasKey(diff))
    return 
}