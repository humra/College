#ifndef _BINARY_TREE_H
#define _BINARY_TREE_H

using namespace std;

typedef int ELTYPE;

struct node;

typedef node* POSITION;

struct node
{
	ELTYPE element;
	POSITION left_child;
	POSITION right_child;
};

class binaryTree
{
private:
	POSITION root_node;
	POSITION create_new_node(const ELTYPE& element);

public:
	void create(const ELTYPE& element);
	bool insert_left(const POSITION parent, const ELTYPE& element);
	bool insert_right(const POSITION parent, const ELTYPE& element);
	POSITION root();
	POSITION get_left_child(const POSITION parent);
	POSITION get_right_child(const POSITION	parent);
	bool get_node(const POSITION pos, ELTYPE& element);
};

#endif