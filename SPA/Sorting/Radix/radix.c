#include <stdio.h>
#include <stdlib.h>

void radix_sort(int* data, int n) {

	int max = data[0];
	int i;
	for(i = 1; i < n; i++) {
		if(data[i] > max) {
			max = data[i];
		}
	}

	int nextIndex[10];
	int exponent = 1;
	int digit;
	int* temp;
	temp = (int*) calloc(n, sizeof(int));

	while(max / exponent > 0) {
		for(i = 0; i < 10; i++) {
			nextIndex[i] = 0;
		}

		for(i = 0; i < n; i++) {
			digit = (data[i] / exponent) % 10;
			nextIndex[digit]++;
		}

		nextIndex[0]--;
		for(i = 1; i < 10; i++) {
			nextIndex[i] += nextIndex[i - 1];
		}

		for(i = n - 1; i >= 0; i--) {
			digit = (data[i] / exponent) % 10;
			temp[nextIndex[digit]] = data[i];
			nextIndex[digit]--;
		}

		for(i = 0; i < n; i++) {
			data[i] = temp[i];
		}

		exponent = exponent * 10;
	}
}

int main() {

	int data[] = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
	int n = sizeof(data) / sizeof(data[0]);

	radix_sort(data, n);

	int i;
	for(i = 0; i < n; i++) {
		printf("%d ", data[i]);
	}

	putchar('\n');
	return 0;
}