#include <iostream>
#include <string>
#include "stog.h"

using namespace std;

int main() {

	stack brojevi;
	ELTYPE x;

	//Is it empty?
	cout << brojevi.is_empty() << endl;

	//Filling up stack
	brojevi.push(22);
	brojevi.push(-100);
	brojevi.push(300);
	brojevi.push(41);

	//Is it empty?
	cout << brojevi.is_empty() << endl;

	//What is on top?
	if (brojevi.top(x)) {
		cout << "Element na vrhu je: " << x << endl;
	}
	else {
		cout << "Greska..." << endl;
	}

	//Pop and print elements.
	while (!brojevi.is_empty()) {
		if (brojevi.pop(x)) {
			cout << "Skinuo: " << x << endl;
		}
		else {
			cout << "Greska..." << endl;
		}
	}

	return 0;
}