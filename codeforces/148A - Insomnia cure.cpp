#include <iostream>
using namespace std;

int main()
{
	int k, l, m, n, d, count = 0;
	cin >> k >> l >> m >> n >> d;

	for (int num = 1; num <= d; num++)
	{
		if (num % k == 0 || num % l == 0 || num % m == 0 || num % n == 0)
		{
			count++;
		}
	}

	cout << count << endl;
	
	return 0;
}
