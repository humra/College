#include <stdio.h>
#include <stdbool.h>

void sort(int* data, int n) {

	bool sorted;
	int temp, i, j;
	for(i = 0; i < (n - 1); i++) {
		sorted = true;
		for(j = 0; j < n - i - 1; j++) {
			if(data[j] > data[j + 1]) {
				temp = data[j];
				data[j] = data[j + 1];
				data[j + 1] = temp;
				sorted = false;
			}
		}

		if(sorted == true) {
			break;
		}
	}
}		

int main() {

	int data[10] = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
	int i;

	sort(data, 10);

	for(i = 0; i < 10; i++) {
	printf("%d ", data[i]);
	}
	printf("\n");
	return 0;
}
