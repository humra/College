#include <iostream>
#include "symbol_table.h"

using namespace std;

symbol_table::symbol_table() {
	ELTYPE* _people = new ELTYPE[98];
}

bool symbol_table::insert(unsigned int key, ELTYPE person) {
	if(_people[key - 1].ID == key) {
		cout << "The element with ID of " << key << " alredy exists!" << endl;
		return 0;
	}

	_people[key - 1] = person;
	return true;
}

bool symbol_table::remove(unsigned int key) {
	if(_people[key - 1].ID != key) {
		cout << "The element with ID " << key << " does not exist!" << endl;
		return false;
	}

	_people[key - 1].ID = -1;
	return true;
}

ELTYPE* symbol_table::find(unsigned int key) {
	if(_people[key - 1].ID != key) {
		return nullptr;
	}

	ELTYPE* pperson = &_people[key - 1];
	return pperson;
}