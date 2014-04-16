#include <iostream>
#include "nove_funkcije.h"

using namespace std;

POS novo_stablo::new_node(int element)
{
	node* novi = new node;
	novi->left_child = nullptr;
	novi->right_child = nullptr;

	return novi;
}

bool novo_stablo::has_left_child(POS pos)
{
	if(pos->left_child == nullptr)
	{
		return false;
	}

	return true;
}

bool novo_stablo::has_right_child(POS pos)
{
	if(pos->right_child == nullptr)
	{
		return false;
	}

	return true;
}

bool novo_stablo::insert(int element)
{
	return true;
}