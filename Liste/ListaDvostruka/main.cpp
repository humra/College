#include <iostream>
#include <string>
#include "lista.h"

using namespace std;

void ispisi_listu(lista& list);

int main()
{
	lista osobe;

	osobe.insert("Suzi", osobe.first());
	ispisi_listu(osobe);
	
	osobe.insert("Emili", osobe.first());
	ispisi_listu(osobe);
	
	osobe.insert("Robert", osobe.first());
	ispisi_listu(osobe);
	
	osobe.insert("Tea", osobe.first());
	ispisi_listu(osobe);
	
	osobe.insert("Humra", osobe.first());
	ispisi_listu(osobe);

	cout << endl << "TRAZENJE OSOBE: " << endl;
	POSITION found = osobe.find("Suzi");

	if(found != osobe.end())
	{
		cout << "Pronadjeno na mjestu " << found << endl;
	}
	else
	{
		cout << "Ne postoji u listi" << endl;
	}
	cout << endl;

	POSITION prva = osobe.first();
	osobe.remove(prva);
	ispisi_listu(osobe);

	while(osobe.first() != osobe.end())
	{
		osobe.remove(osobe.first());
	}
	ispisi_listu(osobe);

	cout << endl;
	return 0;
}

void ispisi_listu(lista& list)
{
	ELTYPE element;

	cout << "ISPIS LISTE: " << endl;

	for(POSITION pos = list.first(); pos != list.end(); pos = list.next(pos))
	{
		list.read(pos, element);
		cout << element << endl;
	}

	cout << endl;
}