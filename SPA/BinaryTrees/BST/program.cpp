#include "bst.h"
#include <iostream>
#include <vector>

using namespace std;

int main() {

	bst stablo;
	stablo.insert(8);
	stablo.insert(3);
	stablo.insert(10);
	stablo.insert(1);
	stablo.insert(6);
	stablo.insert(14);
	stablo.insert(4);
	stablo.insert(7);
	stablo.insert(13);
	stablo.insert(10);
	stablo.insert(10);

	cout << stablo.exists(14) << endl;
	cout << stablo.exists(8) << endl;
	cout << stablo.exists(13) << endl;
	cout << stablo.exists(11) << endl;

	cout << "Found: " << stablo.count_find(10) << endl;
	cout << "Found: " << stablo.count_find(99999) << endl;
	cout << "Found: " << stablo.count_find(7) << endl;

	return 0;
}