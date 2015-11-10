#ifndef _BST_H_
#define _BST_H_

#include <iostream>
#include <vector>
using namespace std;

typedef int ELTYPE;

struct cvor;

typedef cvor* POSITION;

struct cvor {
	ELTYPE element;
	POSITION left_child;
	POSITION right_child;
};

class bst {
private:
	POSITION _root;
	POSITION create_new_node(const ELTYPE& element);
	POSITION insert(const ELTYPE& element, POSITION* parent);
	bool exists(const ELTYPE element, POSITION parent);
	bool find(const ELTYPE& element, POSITION parent, vector<POSITION> &found);

public:
	bst();
	POSITION insert(const ELTYPE& element);
	bool exists(const ELTYPE& element);
	int count_find(ELTYPE element);
};

#endif
