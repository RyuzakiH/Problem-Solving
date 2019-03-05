#include <iostream>
using namespace std;

int main()
{
	int x, y, z, a, b, c;
	cin >> x >> y >> z >> a >> b >> c;

	a -= x;

	if (a < 0)
	{
		cout << "NO" << endl;
		return 0;
	}

	b += a;
	b -= y;

	if (b < 0)
	{
		cout << "NO" << endl;
		return 0;
	}

	c += b;
	c -= z;

	if (c < 0)
	{
		cout << "NO" << endl;
		return 0;
	}

	cout << "YES" << endl;

	return 0;
}
