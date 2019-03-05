#include <iostream>
using namespace std;

int main()
{
	short n, k, temp, participants = 0;
	cin >> n >> k;

	for (short i = 0; i < n; i++)
	{
		cin >> temp;
		if ((k + temp) <= 5)
			participants++;
	}

	cout << participants / 3 << endl;

	return 0;
}