#include <iostream>

using namespace std;

int suma_niza(int niz[], int n, int x)
{
	if(n == 4)
	{
		return niz[n];
	}
	
	return x = suma_niza(niz, n + 1, x) + niz[n];
}

int main()
{
	int niz[5] = {1, 2, 3, 4, 5};

	int zbroj = suma_niza(niz, 0, 0);
	cout << zbroj;

	cout << endl;
	return 0;
}