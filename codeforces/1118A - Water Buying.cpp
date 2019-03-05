#include <iostream>
using namespace std;

int main()
{
	long long n, q, a, b;
	
	cin >> q;

	for (long long i = 0; i < q; i++)
	{
		cin >> n >> a >> b;

		cout << ((a < ((double)b / 2)) ? (n * a) : ((n % 2) ? (n / 2) * b + a : (n / 2) * b)) << endl;
	}

	return 0;
}
