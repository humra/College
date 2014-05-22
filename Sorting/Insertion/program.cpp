#include <iostream>
using namespace std;

void sortiraj(int data[], int n) {

	int temp, i , j;
	for(i = 1; i < n; i++) {
		temp = data[i];
		for(j = i; j >= 1 && data[j -1] > temp; j--) {
			data[j] = data[j - 1];
		}
		data[j] = temp;
	}
}

int main() {

	// Podaci za sortiranje.
	int n = 10;
	int data[] = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

	// Algoritam.
	sortiraj(data, n);

	// Ispis sortiranog polja.
	for (int i = 0; i < n; i++) {
		cout << data[i] << " ";
	}
	cout << endl;

	return 0;
}