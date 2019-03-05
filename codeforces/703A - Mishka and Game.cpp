#include <iostream>
using namespace std;

int main()
{
	short n, mt, ct, m = 0, c = 0;
	cin >> n;

	for (short i = 0; i < n; i++)
	{
		cin >> mt >> ct;
		m += mt > ct;
		c += ct > mt;
	}

	cout << ((m > c) ? "Mishka" : ((m == c) ? "Friendship is magic!^^" : "Chris")) << endl;

	return 0;
}