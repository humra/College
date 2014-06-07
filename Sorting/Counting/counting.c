#include <stdio.h>
#include <stdlib.h>

void counting_sort(int* data, int n) {
	int max = data[0];
	int i;
	for(i = 1; i < n; i++) {
		if(data[i] > max) {
			max = data[i];
		}
	}
	//printf("%d\n", max);

	int* countingArray = (int*) calloc(max + 1, sizeof(int));
	int* sorted = (int*) malloc (n);
	for(i = 0; i < max + 1; i++) {
		countingArray[i] = 0;
		//printf("%d ", countingArray[i]);
	}
	//putchar('\n');

	int temp;
	for(i = 0; i < n; i++) {
		temp = data[i];
		countingArray[temp]++;
	}
	/*for(i = 0; i <= max; i++) {
		printf("%d ", countingArray[i]);
	}*/

	for(i = 1; i <= max; i++) {
		countingArray[i] += countingArray[i - 1];
	}
	/*for(i = 0; i <= max; i++) {
		printf("%d ", countingArray[i]);
	}*/

	for(i = 0; i < n; i++) {
		temp = data[i];
		countingArray[temp]--;
		sorted[countingArray[temp]] = data[i];
	}
	/*for(i = 0; i < n; i++) {
		printf("%d ", sorted[i]);
	}*/

	for(i = 0; i < n; i++) {
		data[i] = sorted[i];
	}
}

int main() {

	int data[] = {4, 5, 2, 1, 3, 2, 2, 4, 5, 3};
	int n = sizeof(data) / sizeof(data[0]);

	counting_sort(data, n);
	//putchar('\n');
	int i;
	for(i = 0; i < n; i++) {
		printf("%d ", data[i]);
	}

	putchar('\n');
	return 0;
}