#include <iostream>
using namespace std;

int main()
{
	short n, k, days = 0, max = 8, temp, candies = 0, given = 0;
	cin >> n >> k;

	for (; days < n; days++)
	{
		cin >> temp;
		
		candies += temp;

		if (candies >= max)
		{
			given += max;
			candies -= max;
		}
		else
		{
			given += candies;
			candies = 0;
		}

		if (given >= k)
		{
			days++;
			break;
		}
	}

	cout << ((days <= n && given >= k) ? days : -1) << endl;

	return 0;
}
