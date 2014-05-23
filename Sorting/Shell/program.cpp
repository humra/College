#include <iostream>
using namespace std;

void sort(int data[], int n) {

	int temp, j;
	for(int step = n / 2; step > 0; step = step / 2) {
		for(int i = step; i < n; i++) {
			temp = data[i];
			j = i;
			while(j >= step && data[j - step] > temp) {
				swap(data[j], data[j - step]);
				j = j - step;
			}
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