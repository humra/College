#ifndef _BINARNO_STABLO_H
#define _BINARNO_STABLO_H

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

	binarno_stablo stablo;

	int numbers[7] = {3, 6, 7, 2, 8, 1, 5};

	stablo = create_tree(numbers, 7);

	int depth = 1;

	tree_depth(stablo.root(), 1, depth);

	cout << depth << endl;

	cout << endl;
	return 0;
}

#endif