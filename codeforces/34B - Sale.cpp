#include <iostream>
#include <algorithm>
#include <functional>
using namespace std;

int main()
{
	int n, m, sets[100], sum(0);
	cin >> n >> m;

	for (int i = 0; i < n; i++)
		cin >> sets[i];

	sort(sets, sets + n, less<int>());

	for (int i = 0; i < m; i++)
		sum += (sets[i] > 0 ? 0 : 1) * sets[i];

	cout << sum * -1 << endl;

	return 0;
}
