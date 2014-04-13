#include <iostream>
#include <string>
#include "lista.h"

using namespace std;

void print_list(lista& list);

int main()
{
	lista osobe;

	osobe.insert("Suzi", 1);
	print_list(osobe);

	osobe.insert("Emily", 1);
	print_list(osobe);

	osobe.insert("Robert", 1);
	print_list(osobe);

	osobe.insert("Tea", 1);
	print_list(osobe);

	osobe.insert("Humra", 3);
	print_list(osobe);

	cout << endl << "TRAZENJE OSOBE: " << endl;
	int found = osobe.find("Emily");

	if(found != osobe.end())
	{
		cout << "Pronasao na mjestu " << found << endl;
	}
	else
	{
		cout << "Ne postoji u listi" << endl;
	}
	cout << endl;

	osobe.remove(3);
	print_list(osobe);

	while(osobe.first() != osobe.end())
	{
		osobe.remove(1);
	}
	print_list(osobe);

	cout << endl;
	return 0;
}

void print_list(lista& list)
{
	string element;
	cout << "ISPIS LISTE: " << endl;

	for(int pos = list.first(); pos < list.end(); pos = list.next(pos))
	{
		list.read(pos, element);
		cout << element << endl;
	}

	cout << endl;
}