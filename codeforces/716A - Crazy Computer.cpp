#include <iostream>
using namespace std;

int main()
{
	int n, c, t, last_t = 0, words = 0;
	cin >> n >> c;

	for (int i = 0; i < n; i++)
	{
		cin >> t;

		if (t - last_t <= c)
			words++;
		else
			words = 1;

		last_t = t;
	}

	cout << words << endl;

	return 0;
}
