#include <stdio.h>
#include <stdlib.h>

void merge(int* dataA, int an, int* dataB, int bn) {
	int* dataC = (int*)calloc(an + bn, sizeof(int));

	int ia = 0;
	int ib = 0;
	int ic;

	for(ic = 0; ic < an + bn; ic++) {
		if(ia == an) {
			dataC[ic] = dataB[ib];
			ib++;
			continue;
		}
		if(ib == bn) {
			dataC[ic] = dataA[ia];
			ia++;
			continue;
		}

		if(dataA[ia] > dataB[ib]) {
			dataC[ic] = dataB[ib];
			ib++;
		}
		else {
			dataC[ic] = dataA[ia];
			ia++;
		}
	}

	int i;
	for(i = 0; i < an + bn; i++) {
		dataA[i] = dataC[i];
	}

	return;
}

void sort(int* data, int from, int to) {
	if(from == to) {
		return;
	}

	int mid;

	mid = (from + to) / 2;
	sort(data, from, mid);
	sort(data, mid + 1, to);

	merge(data + from, mid - from + 1, data + mid + 1, to - mid);
}

int main() {

	int data[] = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

	sort(data, 0, 9);

	int i;
	for(i = 0; i < 10; i++) {
		printf("%d ", data[i]);
	}

	printf("\n");
	return 0;
}