#include <iostream>
using namespace std;

void sort(int data[], int n) {

	int min;
	int minindex;
	for(int i = 0; i < n - 1; i++) {
		min = data[i];
		minindex = i;
		for(int j = i + 1; j < n; j++) {
			if(data[j] < min) {
				min = data[j];
				minindex = j;
			}
		}
		swap(data[i], data[minindex]);
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