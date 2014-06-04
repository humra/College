#ifndef _SYMBOL_TABLE_H_
#define _SYMBOL_TABLE_H_

#include <string>

struct person {
	std::string name;
	std::string lastName;
	int ID;
	int height;
	float pay;
};

typedef person ELTYPE;

class symbol_table {
private:
	ELTYPE _people[98];
public:
	symbol_table();
	bool insert(unsigned int key, ELTYPE person);
	bool remove(unsigned int key);
	ELTYPE* find(unsigned int key);
};

#endif