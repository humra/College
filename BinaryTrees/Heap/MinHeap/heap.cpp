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

	while(pos != 0 && _elements[pos] < _elements[_calcParent(pos)]) {
		swap(_elements[pos], _elements[_calcParent(pos)]);
		pos = _calcParent(pos);
	}
}

void heap::_reheapifyDownward() {
	POSITION pos = 0;

	while(pos < _last / 2) {
		POSITION left_child = _calcLeft(pos);
		POSITION right_child = _calcRight(pos);
		POSITION lesser_index;

		if(left_child >= _last && right_child >= _last) {
			return;
		}
		else if(left_child < _last && right_child >= _last) {
			lesser_index = left_child;
		}
		else {
			if(_elements[left_child] < _elements[right_child]) {
				lesser_index = left_child;
			}
			else {
				lesser_index = right_child;
			}
		} 

		if(_elements[pos] > _elements[lesser_index]) {
			swap(_elements[pos], _elements[lesser_index]);
		}
		else {
			return;
		}

		pos = lesser_index;
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