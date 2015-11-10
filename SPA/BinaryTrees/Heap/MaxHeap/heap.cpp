#include <iostream>
#include "heap.h"

using namespace std;

POSITION heap::_calcLeft(POSITION parent) {
	return parent * 2 + 1;
}

POSITION heap::_calcRight(POSITION parent) {
	return parent * 2 + 2;
}

POSITION heap::_calcParent(POSITION child) {
	return (child - 1) / 2;
}

bool heap::_isFull() {
	return _last == CAPACITY;
}

void heap::_reheapifyUpward() {
	POSITION pos = _last;
	POSITION parent = _calcParent(pos);

	if(pos == 0) {
		return;
	}

	while(pos != 0 && _elements[pos] > _elements[parent]) {
		parent = _calcParent(pos);

		swap(_elements[pos], _elements[parent]);
		pos = parent;
	}
}

void heap::_reheapifyDownward() {
	POSITION pos = 0;
	POSITION left_child = _calcLeft(pos);
	POSITION right_child = _calcRight(pos);
	POSITION greater;

	while(pos < _last) {
		left_child = _calcLeft(pos);
		right_child = _calcRight(pos);

		if(left_child >= _last && right_child >= _last) {
			return;
		}
		else if(left_child < _last && right_child >= _last) {
			greater = left_child;
		}
		else {
			if(_elements[left_child] > _elements[right_child]) {
				greater = left_child;
			}
			else {
				greater = right_child;
			}
		} 

		if(_elements[pos] < _elements[greater]) {
			swap(_elements[pos], _elements[greater]);
		}
		else {
			return;
		}

		pos = greater;
	}
}

heap::heap() {
	_last = 0;
}

bool heap::isEmpty() {
	if(_last == 0) {
		return true;
	}
	return false;
}

void heap::insert(const ELTYPE& element) {
	if(_isFull() == true) {
		cout << "Heap is full" << endl;
		return;
	}

	_elements[_last] = element;
	_reheapifyUpward();

	_last++;
	return;
}

ELTYPE heap::remove() {
	if(isEmpty() == true) {
		cout << "Heap is empty" << endl;
		return 0;
	}

	ELTYPE topElement = _elements[0];
	_last--;

	if(_last != 0) {
		_elements[0] = _elements[_last];
		_reheapifyDownward();
	}

	return topElement;
}

void heap::printTree() {
	POSITION temp = 0;

	while(temp != _last) {
		cout << _elements[temp] << endl;
		temp++;
	}
	return;
}