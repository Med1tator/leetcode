package main

func main() {

}

func reverse(x int) int {
	ans := 0
	ifMax := 214748364
	ifMin := -214748364

	for x != 0 {
		if ans > ifMax || ans < ifMin {
			return 0
		}

		ans = ans*10 + x%10
		x /= 10
	}
	return ans
}
