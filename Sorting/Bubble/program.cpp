#include <iostream>
using namespace std;

void sort(int data[], int n) {

	bool sorted;
	for(int i = 0; i < n; i++) {
		sorted = true;

		for(int j = 0; j < n - i; j++) {
			if(data[j] > data[j + 1]) {
				swap(data[j], data[j + 1]);
				sorted = false;
			}
		}
		
		if(sorted == true) {
			break;
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