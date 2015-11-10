#include "bst.h"

/*************** PRIVATE METHODS ****************/

POSITION bst::create_new_node(const ELTYPE& element) {

	cvor* novi = new cvor;
	novi->element = element;
	novi->left_child = nullptr;
	novi->right_child = nullptr;

	return novi;
}

POSITION bst::insert(const ELTYPE& element, POSITION* parent) {
	if (*parent == nullptr) {
		*parent = create_new_node(element);
		return *parent;
	}

	if (element < (*parent)->element) {
		return insert(element, &(*parent)->left_child);
	}
	else {
		return insert(element, &(*parent)->right_child);
	}
}

bool bst::exists(const ELTYPE element, POSITION parent) {
	if(parent->element == element) {
		return true;
	}
	if(parent->element > element) {
		if(parent->left_child != nullptr) {
			return exists(element, parent->left_child);
		}
	}
	if(parent->element <= element) {
		if(parent->right_child != nullptr) {
			return exists(element, parent->right_child);
		}
	}
	return false;
}
bool bst::find(const ELTYPE& element, POSITION parent, vector<POSITION> &found){
	if(parent == nullptr) {
		return false;
	}

	if(element == parent->element) {
		found.push_back(parent);

		if(parent->right_child == nullptr) {
			return true;
		}
		else {
			find(element, parent->right_child, found);
		}
	}

	if(element < parent->element) {
		find(element, parent->left_child, found);
	}
	else if(element > parent->element) {
		find(element, parent->right_child, found);
	}
	else {
		return false;
	}
}

/*************** PUBLIC METHODS ****************/

bst::bst() {
	_root = nullptr;
}

POSITION bst::insert(const ELTYPE& element) {
	return insert(element, &_root);
}

bool bst::exists(const ELTYPE& element) {
	return exists(element, _root);
}

int bst::count_find(ELTYPE element) {
	vector<POSITION> numbers;
	find(element, _root, numbers);
	return numbers.size();
}