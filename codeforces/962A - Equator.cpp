#include <iostream>
using namespace std;

int main()
{
	int n, a[200000], current(0);
	cin >> n;

	double sum(0);

	for (int i = 0; i < n; i++)
	{
		cin >> a[i];
		sum += a[i];
	}

	for (int i = 0; i < n; i++)
	{
		current += a[i];
		if (current / sum >= 0.5)
		{
			cout << i + 1 << endl;
			break;
		}
	}

	return 0;
}
