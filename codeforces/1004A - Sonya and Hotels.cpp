#include <iostream>
using namespace std;

int main()
{
	long long n, d, x[100], possible(2);
	cin >> n >> d;

	for (int i = 0; i < n; i++)
		cin >> x[i];

	for (int i = 0; i < n - 1; i++)
	{
		int eq = (x[i + 1] - x[i]) - (2 * d);

		if (eq == 0)
			possible++;
		else if (eq >= 1)
			possible += 2;
	}

	cout << possible << endl;

	return 0;
}
