#include <iostream>
using namespace std;

int main()
{
	int n, x, c(0);
	cin >> n >> x;

	for (int i = 1; i <= n && x >= i; i++)
	{
		if (x % i == 0 && x / i <= n)
			c++;
	}

	cout << c << endl;

	return 0;
}