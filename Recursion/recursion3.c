#include <iostream>
#include <string>

using namespace std;

int provjeri_palindrom(string rijec, int duzina)
{
	if(rijec[0] != rijec[duzina -1])
	{
		return 0;
	}
	if(duzina < 1)
	{
		return 1;
	}

	string pomocna;

	for(int i = 1; i < duzina - 1; i++)
	{
		pomocna = rijec[i];
	}

	if(duzina > 1)
	{
		provjeri_palindrom(pomocna, duzina - 1);
	}
}

int main()
{
	string rijec;

	cout << "Unesite rijec: ";
	getline(cin, rijec);

	int x = provjeri_palindrom(rijec, rijec.length());

	if(x == 0)
	{
		cout << "Rijec nije palindrom";
	}
	else
	{
		cout << "Rijec je palindrom";
	}

	cout << endl;
	return 0;
}