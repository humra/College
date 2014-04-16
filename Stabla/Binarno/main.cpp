#include <iostream>
#include "binarno_stablo.h"
#include "nove_funkcije.h"

using namespace std;

int main()
{
	/*binarno_stablo stablo;

	stablo.create("A");

	POSITION cvor_a = stablo.root();
	stablo.insert_left(cvor_a, "B");

	POSITION cvor_b = stablo.get_left_child(cvor_a);
	stablo.insert_left(cvor_b, "C");

	POSITION cvor_c = stablo.get_left_child(cvor_b);
	stablo.insert_left(cvor_c, "D");

	POSITION cvor_d = stablo.get_left_child(cvor_c);
	stablo.insert_left(cvor_d, "E");*/

	novo_stablo stablo;

	stablo.root->element = 2;

	cout << endl;
	return 0;
}