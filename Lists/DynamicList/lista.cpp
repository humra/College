#include "lista.h"

lista::lista()
{
	_tail = new cvor;
	_tail->next = nullptr;

	_head = new cvor;
	_head->next = _tail;
}

POSITION lista::end()
{
	return _tail;
}

POSITION lista::first()
{
	return _head->next;
}

bool lista::insert(ELTYPE element, POSITION pos)
{
	cvor* novi = new cvor;
	novi->element = element;

	cvor* previous = prev(pos);
	previous->next = novi;
	novi->next = pos;

	return true;
}

bool lista::read(POSITION pos, ELTYPE& element)
{
	element = pos->element;
	return true;
}

bool lista::remove(POSITION pos)
{
	cvor* previos = prev(pos);
	previos->next = pos->next;

	delete pos;

	return true;
}

POSITION lista::find(ELTYPE element)
{
	cvor* temp = _head;

	while(temp != end())
	{
		if(temp->element == element)
		{
			return temp;
		}

		temp = temp->next;
	}

	return end();
}

POSITION lista::empty()
{
	cvor* temp = _head->next;

	while(temp != end())
	{
		cvor* dalje = temp->next;
		delete temp;
		temp = dalje;
	}

	_head->next = _tail;

	return end();
}

POSITION lista::next(POSITION pos)
{
	return pos->next;
}

POSITION lista::prev(POSITION pos)
{
	cvor* temp = _head;

	while(temp->next != end() && temp->next != pos)
	{
		temp = temp->next;
	}

	return temp;
}