#ifndef _NOVE_FUNKCIJE_H
#define _NOVE_FUNKCIJE_H

using namespace std;

struct node;

typedef node* POS;

struct node
{
	int element;
	POS left_child;
	POS right_child;
};

class novo_stablo
{
private:
	POS new_node(int element);

public:
	POS root;
	bool has_left_child(POS pos);
	bool has_right_child(POS pos);
	bool insert(int element);
};

#endif