#include <iostream>
using namespace std;

void merge(int* poljea, int na, int* poljeb, int nb) {
	int* poljec = new int[na + nb];

	int ia = 0;
	int ib = 0;

	for(int ic = 0; ic < na + nb; ic++) {
		if(ia == na) {
			poljec[ic] = poljeb[ib];
			ib++;
			continue;
		}
		if(ib == nb) {
			poljec[ic] = poljea[ia];
			ia++;
			continue;
		}

		if(poljea[ia] < poljeb[ib]) {
			poljec[ic] = poljea[ia];
			ia++;
		}
		else {
			poljec[ic] = poljeb[ib];
			ib++;
		}
	}

	for(int i = 0; i < na + nb; i++) {
		poljea[i] = poljec[i];
	}

	delete[] poljec;
}

void merge_sort(int data[], int from, int to) {
	if(from == to) {
		return;
	}

	int mid = (from + to) / 2;
	merge_sort(data, from, mid);
	merge_sort(data, mid + 1, to);

	merge(data + from, mid - from + 1, data + mid + 1, to - mid);
}

int main() {

	int n = 10;
	int data[] = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

	merge_sort(data, 0, n - 1);

	for (int i = 0; i < n; i++) {
		cout << data[i] << " ";
	}
	cout << endl;

	return 0;
}