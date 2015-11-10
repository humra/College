#ifndef _HEAP_H_
#define _HEAP_H_

#include <iostream>

using namespace std;

typedef int ELTYPE;
typedef unsigned int POSITION;

class heap {
private:
	static const POSITION CAPACITY = 100;
	ELTYPE _elements[CAPACITY];
	POSITION _last;
	POSITION _calcLeft(const POSITION parent);
	POSITION _calcRight(const POSITION parent);
	POSITION _calcParent(const POSITION child);
	bool _isFull();
	void _reheapifyUpward();
	void _reheapifyDownward();

public:
	heap();
	bool isEmpty();
	void insert(const ELTYPE& element);
	ELTYPE remove();
	void printTree();
};

#endif
