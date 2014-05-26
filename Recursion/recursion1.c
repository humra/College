#include <stdio.h>

void recursion1(int* d, int n) {
	printf("%d ", d[n]);
	n++;
	if(n != 5) {
		recursion1(d, n);
	}
}

void recursion2(int* d, int n) {
	printf("%d ", d[n]);
	n--;
	if(n >= 0) {
		recursion2(d, n);
	}
}

int main() {
	int data[5] = {1, 2, 3, 4, 5};

	recursion1(data, 0);
	printf("\n");
	recursion2(data, 4);

	printf("\n");
	return 0;
}