#include <iostream>

using namespace std;

int prebroji(int broj, int znamenka)
{
	if(broj == 0)
	{
		return 0;
	}

	if(broj % 10 == znamenka)
	{
		return 1 + prebroji(broj / 10, znamenka);
	}
	else
	{
		return prebroji(broj / 10, znamenka);
	}
}

int main()
{
	int broj;
	int znamenka;

	cout << "Unesite broj: ";
	cin >> broj;
	cout << "Unesite znamenku: ";
	cin >> znamenka;

	int x = prebroji(broj, znamenka);

	cout << x;

	cout << endl;
	return 0;
}