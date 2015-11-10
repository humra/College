#include "list.h"

list::list() {
	_head = new node;
	_tail = new node;

	_head->previous = nullptr;
	_head->next = _tail;

	_tail->previous = _head;
	_tail->next = nullptr;
}

POSITION list::end() {
	return _tail;
}

POSITION list::first() {
	return _head->next;
}

bool list::insert(ELTYPE element, POSITION pos) {
	node* temp = new node;

	temp->element = element;
	temp->previous = pos->previous;
	temp->next = pos;

	pos->previous->next = temp;
	pos->previous = temp;

	return true;
}

bool list::read(POSITION pos, ELTYPE& element) {
	element = pos->element;
	return true;
}

bool list::remove(POSITION pos) {
	pos->previous->next = pos->next;
	pos->next->previous = pos->previous;
	
	delete pos;

	return true;
}

POSITION list::empty() {
	node* temp = _head->next;
	while (temp != end()) {
		node* nextOne = temp->next;
		delete temp;
		temp = nextOne;
	}

	_head->next = _tail;

	return end();
}

POSITION list::next(POSITION pos) {
	return pos->next;
}

POSITION list::prev(POSITION pos) {
	return pos->previous;
}