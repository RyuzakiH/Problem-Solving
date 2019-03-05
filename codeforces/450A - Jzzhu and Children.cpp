#include <iostream>
#include <queue>
using namespace std;

int main()
{
	int n, m, c, last;
	cin >> n >> m;

	queue<pair<int, int>> q;

	for (int i = 0; i < n; i++)
	{
		cin >> c;
		q.push(make_pair(i, c));
	}

	while (q.size() != 1)
	{
		pair<int, int> old = q.front();
		if (old.second > m)
			q.push(make_pair(old.first, old.second - m));
		q.pop();
	}

	cout << q.front().first + 1 << endl;

	return 0;
}
