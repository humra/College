#include <iostream>
#include "heap.h"

using namespace std;

int main() {
	heap numbers;

	numbers.insert(4);
	numbers.insert(21);
	numbers.insert(45);
	numbers.insert(42);
	numbers.insert(35);
	numbers.insert(19);
	numbers.insert(23);
	numbers.insert(7);

	numbers.printTree();
	cout << endl;
	while(!numbers.isEmpty()) {
		cout << numbers.remove() << endl;
	}

	cout << endl;
	return 0;
}
