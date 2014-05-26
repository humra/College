#include <stdio.h>

void sort(int* data, int n) {

	int temp, j, step, i, tempSwap;
	for(step = n / 2; step > 0; step = step / 2) {
		for(i = step; i < n; i++) {
			temp = data[i];
			j = i;
			
			while(j >= step && data[j - step] > temp) {
				tempSwap = data[j];
				data[j] = data[j - step];
				data[j - step] = tempSwap;
				j = j - step;
			}
		}
	}
}

int main() {

	int data[] = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
	
	sort(data, 10);

	int i;
	for(i = 0; i < 10; i++) {
		printf("%d ", data[i]);
	}

	printf("\n");
	return 0;
}
