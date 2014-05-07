#ifndef _STOG_H_
#define _STOG_H_

#include <string>
using namespace std;

typedef int ELTYPE;

struct node {
	ELTYPE element;
	node* under;
};

class stack {
private:
	node* _top;
	node* _bottom;
	
public:
	stack();
	void empty();
	bool is_empty();
	bool push(ELTYPE element);
	bool pop(ELTYPE& element);
	bool top(ELTYPE& element);
};

#endif