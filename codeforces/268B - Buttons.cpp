#include <iostream>
using namespace std;

int main()
{
	short n;
	cin >> n;

	int sum = 0;
	for (short i = 0; i < n; i++)
		sum += 1 + i * (n - i);

	cout << sum << endl;

	return 0;
}