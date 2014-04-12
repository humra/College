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
	if(_bottom == nullptr)
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

	if(is_empty() == true)
	{
		_top->under = temp;
		_bottom->under = temp;
	}
	else
	{
		temp->under = _top->under;
		_top->under = temp;
	}

	return true;
}

bool stack::pop(ELTYPE& element)
{
	node* temp = _top->under;

	element = _top->element;

	_top->under = _top->under->under;

	delete temp;

	return true;
}

bool stack::top(ELTYPE& element)
{
	element = _top->element;

	return true;
}