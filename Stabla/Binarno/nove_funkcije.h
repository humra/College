#ifndef _NOVE_FUNKCIJE_H
#define _NOVE_FUNKCIJE_H

using namespace std;

void insert_into_tree(ELTYPE broj, binarno_stablo& tempTree, POSITION temp_node);
binarno_stablo create_tree(ELTYPE* brojevi, int brojeviSize);
void tree_depth(POSITION temp_node, int current_level, int& depth);
void tree_leaves(POSITION temp_node, int& leaves);

#endif