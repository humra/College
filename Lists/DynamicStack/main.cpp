#include <iostream>
#include <string>
#include "stack.h"

using namespace std;

int main() {

	stack numbers;
	ELTYPE x;

	//Is it empty?
	cout << numbers.is_empty() << endl;

	//Filling up stack
	numbers.push(22);
	numbers.push(-100);
	numbers.push(300);
	numbers.push(41);

	//Is it empty?
	cout << numbers.is_empty() << endl;

	//What is on top?
	if (numbers.top(x)) {
		cout << "Element na vrhu je: " << x << endl;
	}
	else {
		cout << "Greska..." << endl;
	}

	//Pop and print elements.
	while (!numbers.is_empty()) {
		if (numbers.pop(x)) {
			cout << "Skinuo: " << x << endl;
		}
		else {
			cout << "Greska..." << endl;
		}
	}

	return 0;
}