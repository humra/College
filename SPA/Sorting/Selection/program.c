#include <stdio.h>

void sort(int* data, int n) {
	
	int j, minindex, x, temp;
	for(j = 0; j < n - 1; j++) {
		minindex = j;
		for(x = j + 1; x < n; x++) {
			if(data[x] < data[minindex]) {
				minindex = x;
			}
		}
		if(minindex != j) {
			temp = data[j];
			data[j] = data[minindex];
			data[minindex] = temp;
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
