#include <iostream>

using namespace std;

int binary_search(int* data, int n, int element) {
	int checkings = 0;
	int lowest = 0;
	int highest = n - 1;
	int mid;

	while(lowest <= highest) {
		checkings++;

		mid = (lowest + highest) / 2;

		if(data[mid] == element) {
			cout << "Element found in " << checkings << " searches" << endl;
			return mid;
		}
		else if(data[mid] < element) {
			lowest = mid + 1;
		}
		else {
			highest = mid - 1;
		}
	}

	return -1;
}

int main() {

	int data[] = { 1, 3, 4, 5, 6, 6, 8, 10, 14, 17, 19, 35, 85, 99, 117, 129, 135, 139, 141, 141, 153, 199 };

	//Searching for 199 becase that would be the worst case scenario in linear search
	int index = binary_search(data, sizeof(data) / sizeof(data[0]), 199);

	if(index == -1) {
		cout << "The value is not in an array";
	}
	else {
		cout << "The value is stored on index " << index;
	}

	cout << endl;
	return 0;
}