#ifndef _BINARNO_STABLO_H
#define _BINARNO_STABLO_H

#include <iostream>
#include <string>
#include "binarno_stablo.h"
#include "nove_funkcije.h"

using namespace std;

void insert_into_tree(ELTYPE broj, binarno_stablo& tempTree, POSITION temp_node)
{
	if(broj > temp_node->element)
	{
		if(temp_node->right_child != nullptr)
		{
			insert_into_tree(broj, tempTree, temp_node->right_child);
		}

		tempTree.insert_right(temp_node, broj);
	}
	else
	{
		if(temp_node->left_child != nullptr)
		{
			insert_into_tree(broj, tempTree, temp_node->left_child);
		}

		tempTree.insert_left(temp_node, broj);
	}

	return;
}

binarno_stablo create_tree(ELTYPE* brojevi, int brojeviSize)
{
	binarno_stablo tempTree;
	tempTree.create(brojevi[0]);

	for(int i = 1; i < brojeviSize; i++)
	{
		insert_into_tree(brojevi[i], tempTree, tempTree.root());
	}

	return tempTree;
}

#endif