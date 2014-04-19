#include <iostream>
#include "extra_functions.h"

using namespace std;

binaryTree create_tree(ELTYPE* numbers, int numbersSize)
{
	binaryTree tempTree;
	tempTree.create(numbers[0]);

	for(int i = 1; i < numbersSize; i++)
	{
		insert_into_tree(numbers[i], tempTree, tempTree.root());
	}

	return tempTree;
}

void tree_depth(POSITION temp_node, int current_level, int& depth)
{
	if(current_level > depth)
	{
		depth = current_level;
	}
	if(temp_node->left_child != nullptr)
	{
		tree_depth(temp_node->left_child, current_level + 1, depth);
	}
	if(temp_node->right_child != nullptr)
	{
		tree_depth(temp_node->right_child, current_level + 1, depth);
	}

	return;
}

void tree_leaves(POSITION temp_node, int& leaves)
{
	if(temp_node->right_child == nullptr && temp_node->left_child == nullptr)
	{
		leaves++;
	}
	if(temp_node->right_child != nullptr)
	{
		tree_leaves(temp_node->right_child, leaves);
	}
	if(temp_node->left_child != nullptr)
	{
		tree_leaves(temp_node->left_child, leaves);
	}

	return;
}

void insert_into_tree(ELTYPE number, binaryTree& tempTree, POSITION temp_node)
{
	if(number > temp_node->element)
	{
		if(temp_node->right_child != nullptr)
		{
			insert_into_tree(number, tempTree, temp_node->right_child);
		}

		tempTree.insert_right(temp_node, number);
	}
	else
	{
		if(temp_node->left_child != nullptr)
		{
			insert_into_tree(number, tempTree, temp_node->left_child);
		}

		tempTree.insert_left(temp_node, number);
	}

	return;
}

void tree_smallest(POSITION temp_node, int& smallest)
{
	if(temp_node->element < smallest)
	{
		smallest = temp_node->element;
	}
	if(temp_node->right_child != nullptr)
	{
		tree_smallest(temp_node->right_child, smallest);
	}
	if(temp_node->left_child != nullptr)
	{
		tree_smallest(temp_node->left_child, smallest);
	}

	return;
}

void tree_odd_sum(POSITION temp_node, int& sum)
{
	if(temp_node->element % 2 == 1)
	{
		sum += temp_node->element;
	}
	if(temp_node->right_child != nullptr)
	{
		tree_odd_sum(temp_node->right_child, sum);
	}
	if(temp_node->left_child != nullptr)
	{
		tree_odd_sum(temp_node->left_child, sum);
	}

	return;
}