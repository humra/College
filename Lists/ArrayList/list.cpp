#include "list.h"

lista::lista()
{
	_last = 0;
}

uint lista::end()
{
	return _last + 1;
}

uint lista::first()
{
	return 1;
}

bool lista::insert(string element, uint pos)
{
	//We test if position for inserting is valid
	//Position is valid if it is inside the list or on the "first after" but only if
	//"first after" fits in the array
	if(pos >= first() && pos <= end() && _last < 10)
	{
		for(uint i = _last; i >= pos; i--)
		{
			_elements[i] = _elements[i - 1];
		}

		_elements[pos - 1] = element;
		_last++;

		return true;
	}

	return false;
}

bool lista::read(uint pos, string& element)
{
	if(pos >= first() && pos < end())
	{
		element = _elements[pos - 1];
		return true;
	}

	return false;
}

bool lista::remove(uint pos)
{
	if(pos >= first() && pos < end())
	{
		for(uint i = pos - 1; i < _last - 1; i++)
		{
			_elements[i] = _elements[i + 1];
		}

		_last--;
		return true;
	}

	return false;
}

uint lista::find(string element)
{
	for(uint i = first(); i < end(); i++)
	{
		if(_elements[i] == element)
		{
			return i + 1;
		}
	}

	return end();
}

uint lista::empty()
{
	_last = 0;
	return end();
}

uint lista::next(uint pos)
{
	return pos + 1;
}

uint lista::prev(uint pos)
{
	return pos - 1;
}