#include <stdio.h>

int array_sum(int* data, int n) {
	if(n < 0) {
		return 0;
	}

	return data[n] + array_sum(data, n - 1);
}

int main() {

	int data[] = {1, 2, 3, 4, 5};

	int sum = array_sum(data, 4);

	printf("Sum of the array is: %d\n", sum);
	return 0;
}