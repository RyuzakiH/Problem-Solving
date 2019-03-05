#include <iostream>
using namespace std;

int main()
{
	int a, b, c, n;
	cin >> a >> b >> c >> n;

	int f = n - (a + b - c);

	cout << (f >= 1 && a >= c && b >= c ? f : -1) << endl;

	return 0;
}
