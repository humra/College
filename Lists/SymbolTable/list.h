#ifndef _list_H_
#define _list_H_

#include <string>
#include "student.h"

using namespace std;

typedef student ELTYPE;

struct node;

typedef node* POSITION;

struct node {
	ELTYPE element;
	POSITION previous;
	POSITION next;
};

class list {
private:
	POSITION _head; // "Prvi ispred" poèetka liste.
	POSITION _tail; // "Prvi iza" kraja liste.

public:
	list();
	POSITION end();
	POSITION first();
	bool insert(ELTYPE element, POSITION pos);
	bool read(POSITION pos, ELTYPE& element);
	bool remove(POSITION pos);
	POSITION empty();
	POSITION next(POSITION pos);
	POSITION prev(POSITION pos);
};

#endif