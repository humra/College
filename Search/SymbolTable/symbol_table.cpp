#include <iostream>
#include "symbol_table.h"

using namespace std;

symbol_table::symbol_table() {
	ELTYPE* _people = new ELTYPE[98];
}

bool symbol_table::insert(unsigned int key, ELTYPE person) {
	if(_people[key].ID == key) {
		cout << "The element with ID of " << key << " alredy exists!" << endl;
		return 0;
	}

	_people[key] = person;
	return true;
}

bool symbol_table::remove(unsigned int key) {
	if(_people[key].ID != key) {
		cout << "The element with ID " << key << " does not exist!" << endl;
		return false;
	}

	_people[key].ID = 0;
	_people[key].name = "";
	_people[key].lastName = "";
	_people[key].height = 0;
	_people[key].pay = 0;
	return true;
}

ELTYPE* symbol_table::find(unsigned int key) {
	if(_people[key].ID != key) {
		return nullptr;
	}

	ELTYPE* pperson = &_people[key];
	return pperson;
}