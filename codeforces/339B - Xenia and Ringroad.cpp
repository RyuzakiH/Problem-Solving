#include <iostream>
using namespace std;

int main()
{
	long long n, m, current(1), a, time(0);
	cin >> n >> m;

	for (long long i = 0; i < m; i++)
	{
		cin >> a;

		if (a > current)
			time += a - current;
		else if (a < current)
			time += n + a - current;

		current = a;
	}

	cout << time << endl;

	return 0;
}

