#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
	long long n, w, h, current(2e9), maxx, minn;
	cin >> n;

	for (long long i = 0; i < n; i++)
	{
		cin >> w >> h;

		if ((maxx = max(w, h)) <= current)
			current = maxx;
		else if ((minn = min(w, h)) <= current)
			current = minn;
		else
		{
			cout << "NO" << endl;
			return 0;
		}
	}

	cout << "YES" << endl;

	return 0;
}