#ifndef _LISTA_H_
#define _LISTA_H_

#include <string>

using namespace std;

typedef string ELTYPE;

struct cvor;

typedef cvor* POSITION;

struct cvor
{
	ELTYPE element;
	POSITION previous;
	POSITION next;
};

class lista
{
private:
	POSITION _head; //first before the start of the list
	POSITION _tail; // first after the end of the list

public:
	lista();
	POSITION end();
	POSITION first();
	bool insert(ELTYPE element, POSITION pos);
	bool read(POSITION pos, ELTYPE& element);
	bool remove(POSITION pos);
	POSITION find(ELTYPE element);
	POSITION empty();
	POSITION next(POSITION pos);
	POSITION prev(POSITION pos);
};

#endif