#include <iostream>
#include "binary_tree.h"

using namespace std;

POSITION binaryTree::create_new_node(const ELTYPE& element)
{
	node* temp = new node;
	temp->element = element;
	temp->left_child = nullptr;
	temp->right_child = nullptr;

	return temp; 
}

void binaryTree::create(const ELTYPE& element)
{
	root_node = create_new_node(element);
}

bool binaryTree::insert_left(const POSITION parent, const ELTYPE& element)
{
	if(parent->left_child != nullptr)
	{
		return false;
	}

	parent->left_child = create_new_node(element);
	return true;
}

bool binaryTree::insert_right(const POSITION parent, const ELTYPE& element)
{
	if(parent->right_child != nullptr)
	{
		return false;
	}

	parent->right_child = create_new_node(element);
	return true;
}

POSITION binaryTree::root()
{
	return root_node;
}

POSITION binaryTree::get_left_child(const POSITION parent)
{
	return parent->left_child;
}

POSITION binaryTree::get_right_child(const POSITION parent)
{
	return parent->right_child;
}

bool binaryTree::get_node(const POSITION pos, ELTYPE& element)
{
	element = pos->element;
	return true;
}