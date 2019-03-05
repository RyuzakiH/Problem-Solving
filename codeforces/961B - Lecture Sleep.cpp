#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
	int n, k, ans, a[100001], b[100001], add(0), s(0), i, j;
	cin >> n >> k;

	for (i = 1; i <= n; i++)
		cin >> a[i];

	for (i = 1; i <= n; i++)
	{
		cin >> b[i];
		if (b[i])
			s += a[i];
	}

	for (i = 1; i <= k; i++)
		if (!b[i])
			add += a[i];

	ans = add;
	for (i = 2, j = k + 1; j <= n; i++, j++)
	{
		if (!b[i - 1])
			add -= a[i - 1];
		if (!b[j])
			add += a[j];
		ans = max(add, ans);
	}

	cout << ans + s << endl;

	return 0;
}