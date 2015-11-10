#include <iostream>
#include <string>
#include "array_queue.h"

using namespace std;

queue::queue() {
	_head = 0;
	_tail = 0;
}

bool queue::_isFull() {
	if(_tail + 1 == _head) {
		return true;
	}
	return false;
}

bool queue::isEmpty() {
	if(_tail == _head) {
		return true;
	}
	return false;
}

bool queue::enqueue(string element) {
	if(_isFull() == true) {
		return false;
	}
	_elements[_tail] = element;
	_tail = (_tail + 1) % CAPACITY;
	cout << "Enqued: " << element << endl;
	return true;
}

bool queue::dequeue(string& element) {
	if(_isFull() == true) {
		return false;
	}
	element = _elements[_head];
	_head = (_head + 1) % CAPACITY;
	cout << "Dequeued: " << element << endl;
	return true;
}

bool queue::front(string& element) {
	if(isEmpty() == true) {
		return false;
	}
	element = _elements[_head];
	return true;
}