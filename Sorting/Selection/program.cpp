#include <iostream>
using namespace std;

void sort(int data[], int n) {

	int minindex;
	for(int i = 0; i < n - 1; i++) {
		minindex = i;
		for(int j = i + 1; j < n; j++) {
			if(data[j] < data[minindex]) {
				minindex = j;
			}
		}
		if(minindex != i) {
			swap(data[i], data[minindex]);
		}
	}
}

int main() {

	int n = 10;
	int data[] = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

	sort(data, n);

	for (int i = 0; i < n; i++) {
		cout << data[i] << " ";
	}
	cout << endl;

	return 0;
}