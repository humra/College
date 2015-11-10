#include <stdio.h>

int binary_search(int* data, int n, int element) {

	int checkings = 0;
	int lowest = 0;
	int highest = n - 1;
	int mid;

	while(lowest <= highest) {
		checkings++;
		mid = (lowest + highest) / 2;

		if(data[mid] == element) {
			printf("The element is found in %d searches\n", checkings);
			return mid;
		}
		else if(data[mid] < element) {
			lowest = mid + 1;
		}
		else {
			highest = mid - 1;
		}
	}

	return -1;
}

int main() {

		int data[22] = { 1, 3, 4, 5, 6, 6, 8, 10, 14, 17, 19, 35, 85, 99, 117, 129, 135, 139, 141, 141, 153, 199 };

		int index;
		index = binary_search(data, sizeof(data) / sizeof(data[0]), 199);

		if(index == -1) {
			printf("The element is not in an array\n");
		}
		else {
			printf("The element is located on index %d\n", index);
		}

		return 0;
}