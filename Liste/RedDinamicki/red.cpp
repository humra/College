#include "red.h"

red::red()
{
	_head = new cvor;
	_head->next = nullptr;

	_tail = new cvor;
	_tail->next = nullptr;
}

bool red::is_empty()
{
	if(_head->next == nullptr && _tail->next == nullptr)
	{
		return true;
	}

	return false;
}

bool red::enqueue(ELTYPE element)
{
	cvor* temp = new cvor;

	temp->element = element;
	temp->next = nullptr;

	if(_head->next == nullptr)
	{
		_head->next = temp;
	}

	if(_tail->next != nullptr)
	{
		_tail->next->next = temp;
	}

	_tail->next = temp;

	return true;
}

bool red::dequeue(ELTYPE& element)
{
	if(is_empty() == true)
	{
		return false;
	}

	cvor* first = _head->next;

	if(first->next == nullptr)
	{
		_head->next = nullptr;
		_tail->next = nullptr;
	}
	else
	{
		_head->next = first->next;
	}

	element = first->element;

	delete first;

	return true;
}

bool red::front(ELTYPE& element)
{
	element = _head->next->element;

	return true;
}