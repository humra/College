#include "stog.h"

stack::stack()
{
	_top = new node;
	_bottom = new node;

	_top = _bottom;
	_bottom = nullptr;
}

bool stack::is_empty()
{
	if(_top->under == _bottom)
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool stack::push(ELTYPE element)
{
	node* temp = new node;
	temp->element = element; //*(temp).element

	temp->under = _top->under;
	_top->under = temp;

	return true;
}

bool stack::pop(ELTYPE& element)
{
	node* temp = _top->under;

	element = _top->under->element;

	_top->under = _top->under->under;

	delete temp;

	return true;
}

bool stack::top(ELTYPE& element)
{
	if(is_empty())
	{
		return false;
	}
	
	element = _top->under->element;

	return true;
}