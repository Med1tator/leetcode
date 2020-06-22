package main

func main() {}

func twoSum(nums []int, target int) []int {
	length := len(nums)

	for i, v := range nums {
		for j := 0; j < length; j++ {
			if nums[j] == target-v {
				return []int{i, j}
			}
		}
	}

	return []int{}
}
