#include <iostream>
using namespace std;

int gcd(int a, int b)
{
	return b == 0 ? a : gcd(b, a % b);
}

int main()
{
	short a, b, heap, current = 0;
	cin >> a >> b >> heap;

	while (heap > 0)
	{
		short temp = gcd((current == 0) ? a : b, heap);

		if (temp <= heap)
			heap -= temp;
		else
			break;

		current = (current == 0) ? 1 : 0;
	}

	cout << ((current == 0) ? 1 : 0) << endl;

	return 0;
}