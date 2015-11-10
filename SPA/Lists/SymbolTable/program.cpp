#include <iostream>
#include <string>
#include "symbol_table.h"

using namespace std;

void print_out(student* s) {
	if (s != nullptr) {
		cout << "Found the student: " << s->name << " " << s->lastName << endl;
	}
	else {
		cout << "The student you are looking for does not exist" << endl;
	}
}

int main() {

	student s1;
	s1.name = "Miro";
	s1.lastName = "Miric";
	s1.indexNumber = "9584515151";
	s1.jmbag = "1111111111";

	student s2;
	s2.name = "Ana";
	s2.lastName = "Anic";
	s2.indexNumber = "8511815415";
	s2.jmbag = "2222222222";

	student s3;
	s3.name = "Iva";
	s3.lastName = "Ivic";
	s3.indexNumber = "9876422818";
	s3.jmbag = "3333333333";

	symbol_table st;
	st.put(s1.jmbag, s1);
	st.put(s2.jmbag, s2);
	st.put(s3.jmbag, s3);

	student* existing = st.get("2222222222");
	print_out(existing);

	existing = st.get("5555555555");
	print_out(existing);

	st.remove("2222222222");

	existing = st.get("2222222222");
	print_out(existing);

	return 0;
}