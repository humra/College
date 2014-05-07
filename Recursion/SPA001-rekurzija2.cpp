#include <iostream>

using namespace std;

int suma_niza(int niz[], int n)
{
	if(n < 0)
	{
		return 0;
	}
	else
	{
		return niz[n] + suma_niza(niz, n -1);
	}
}

int main()
{
	int niz[5] = {1, 2, 3, 4, 5};

	int suma = suma_niza(niz, 4);

	cout << suma;

	cout << endl;
	return 0;
}