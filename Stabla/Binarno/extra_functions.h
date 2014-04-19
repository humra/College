#ifndef _EXTRA_FUNCTIONS_H
#define _EXTRA_FUNCTIONS_H

#include "binary_tree.h"

binaryTree create_tree(ELTYPE* numbers, int numbersSize);
void tree_depth(POSITION temp_node, int current_level, int& depth);
void tree_leaves(POSITION temp_node, int& leaves);
void insert_into_tree(ELTYPE number, binaryTree& tempTree, POSITION temp_node);
void tree_smallest(POSITION temp_node, int& smallest);
void tree_odd_sum(POSITION temp_node, int& sum);

#endif