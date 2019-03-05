#include <bits/stdc++.h>
using namespace std;

int main()
{
	int a, b, c;
	cin >> a >> b >> c;

	int x = sqrt(1.0 * a * b / c);
	int y = sqrt(1.0 * a * c / b);
	int z = sqrt(1.0 * b * c / a);

	cout << 4 * (x + y + z) << endl;

	return 0;
}
