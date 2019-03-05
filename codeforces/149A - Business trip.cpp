#include <iostream>
#include <algorithm>
#include <functional>
using namespace std;

int main()
{
	int k, m[12], count(0), sum(0);
	cin >> k;

	for (int i = 0; i < 12; i++)
		cin >> m[i];

	sort(m, m + 12, greater<int>());

	for (int i = 0; i < 12 && sum < k; i++)
		sum += m[count++];

	cout << (sum >= k ? count : -1) << endl;

	return 0;
}
