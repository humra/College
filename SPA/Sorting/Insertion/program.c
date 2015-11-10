#include <stdio.h>

void sort(int* data, int n) {
	
	int i, j, temp;
	for(i = 0; i < n; i++) {
		temp = data[i];
		for(j = i; j >= 1 && data[j - 1] > temp; j--) {
			data[j] = data[j - 1];
		}
		data[j] = temp;
	}
}

int main() {
	
	int data[] = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

	sort(data, 10);

	int x;
	for(x = 0; x < 10; x++) {
		printf("%d ", data[x]);
	}
	
	printf("\n");
	return 0;
}
