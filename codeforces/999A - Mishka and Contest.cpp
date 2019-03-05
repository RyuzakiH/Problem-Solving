#include <iostream>
using namespace std;

int main()
{
	int n, k, difficulties[100], last_right, solved(0);
	cin >> n >> k;

	for (int i = 0; i < n; i++)
		cin >> difficulties[i];

	for (last_right = 0; last_right < n && difficulties[last_right] <= k; last_right++, solved++);

	for (int i = n - 1; i > last_right && difficulties[i] <= k; i--, solved++);

	cout << solved << endl;

	return 0;
}
