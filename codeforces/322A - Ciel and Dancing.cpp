#include <iostream>
using namespace std;

int main()
{
	int n, m;
	cin >> n >> m;

	cout << n + m - 1 << endl;

	for (int i = (n > m ? 1 : 2); i <= n; i++)
		cout << i << " " << 1 << endl;

	for (int j = (n > m ? 2 : 1); j <= m; j++)
		cout << 1 << " " << j << endl;

	return 0;
}