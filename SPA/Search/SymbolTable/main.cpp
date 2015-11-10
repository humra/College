#include <iostream>
#include <string>
#include <fstream>
#include "symbol_table.h"

using namespace std;

int main() {

	person temp;
	symbol_table st;
	symbol_table();

	ifstream datin("osobe.txt");
	if(!datin) {
		cout << "Error" << endl;
		return 1;
	}

	while(datin >> temp.ID) {
		datin.ignore();
		getline(datin, temp.name, ' ');
		getline(datin, temp.lastName, '\t');
		datin >> temp.height;
		datin >> temp.pay;
		st.insert(temp.ID, temp);
	}

	st.remove(11);
	st.remove(32);
	st.remove(4);

	person* p = st.find(81);
	temp = *p;

	return 0;
}