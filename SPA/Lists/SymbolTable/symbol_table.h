#ifndef _SYMBOL_TABLE_H_
#define _SYMBOL_TABLE_H_

#include <string>
#include "student.h"
#include "list.h"

using namespace std;

class symbol_table {
private:
	list _list;

public:
	symbol_table();
	bool put(string key, ELTYPE value);
	ELTYPE* get(string key);
	bool remove(string key);
};

#endif