#include <iostream>
using namespace std;

int main()
{
	short n, num, even(0), last_odd(0), last_even(0);
	cin >> n;

	for (short i = 1; i <= n; i++)
	{
		cin >> num;

		even += !(num % 2);

		if (num % 2)
			last_odd = i;
		else
			last_even = i;
	}

	cout << (even >= 2 ? last_odd : last_even) <<endl;

	return 0;
}
