#include "symbol_table.h"

symbol_table::symbol_table() {
}

bool symbol_table::put(string key, ELTYPE value) {
	for(POSITION pos = _list.first(); pos != _list.end(); pos = pos->next) {
		if(pos->element.jmbag == key) {
			return false; //The elment already exists
		}
	}

	_list.insert(value, _list.end());
	return true;
}

ELTYPE* symbol_table::get(string key) {
	for(POSITION pos = _list.first(); pos != _list.end(); pos = pos->next) {
		if(pos->element.jmbag == key) {
			return &pos->element;
		}
	}

	return nullptr;
}

bool symbol_table::remove(string key) {
	for(POSITION pos = _list.first(); pos != _list.end(); pos = pos->next) {
		if(pos->element.jmbag == key) {
			_list.remove(pos);
			return true;
		}
	}

	return false;
}
