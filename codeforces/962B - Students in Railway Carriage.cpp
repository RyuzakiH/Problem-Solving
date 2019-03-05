#include <iostream>
#include <string>
#include <math.h>
#include <algorithm>
using namespace std;

int main()
{
	int n, a, b, count(0), total(0);
	cin >> n >> a >> b;

	total = a + b;

	string seats;
	cin >> seats;
	seats.push_back('*');

	int current(0);
	for (int i = 0; i <= n && (a > 0 || b > 0); i++)
	{
		if (seats[i] == '*')
		{
			if (a < b) swap(a, b);

			a -= min(a, current / 2);
			b -= min(b, current / 2);

			a -= min(a, current % 2);

			current = 0;
		}
		else
			current++;
	}

	cout << (total - a - b) << endl;

	return 0;
}
