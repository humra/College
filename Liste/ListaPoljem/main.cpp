#include <iostream>
#include <string>
#include "lista.h"

using namespace std;

void ispisi_listu(lista& list);

int main()
{
	lista osobe;

	osobe.insert("Suzi", 1);
	ispisi_listu(osobe);

	osobe.insert("Emily", 1);
	ispisi_listu(osobe);

	osobe.insert("Robert", 1);
	ispisi_listu(osobe);

	osobe.insert("Tea", 1);
	ispisi_listu(osobe);

	osobe.insert("Humra", 3);
	ispisi_listu(osobe);

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
	ispisi_listu(osobe);

	while(osobe.first() != osobe.end())
	{
		osobe.remove(1);
	}
	ispisi_listu(osobe);

	cout << endl;
	return 0;
}

void ispisi_listu(lista& list)
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