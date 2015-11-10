#ifndef _LIST_H_
#define _LIST_H_

#include <string>

using namespace std;

typedef unsigned int uint;

class lista
{
private:
	string _elements[10];
	uint _last; //last element in the list

public:
	lista();
	uint end();
	uint first();
	bool insert(string element, uint pos);
	bool read(uint pos, string& element);
	bool remove(uint pos);
	uint find(string element);
	uint empty();
	uint next(uint pos);
	uint prev(uint pos);
};

#endif