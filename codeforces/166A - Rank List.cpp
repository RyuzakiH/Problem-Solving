#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
	int n, k, p, t;
	cin >> n >> k;

	vector<pair<int, int>> ranking;

	for (int i = 0; i < n; i++)
		cin >> p >> t, ranking.push_back(make_pair(p, t));

	sort(ranking.begin(), ranking.end(), [](auto &left, auto &right) {
		return left.first > right.first || (left.first == right.first && left.second < right.second);
	});

	int sum = 1;

	for (int i = k; i < n; i++, sum++)
	{
		if (!(ranking[k - 1].first == ranking[i].first && ranking[k - 1].second == ranking[i].second))
			break;
	}

	for (int i = k - 2; i >= 0; i--, sum++)
	{
		if (!(ranking[k - 1].first == ranking[i].first && ranking[k - 1].second == ranking[i].second))
			break;
	}

	cout << sum << endl;

	return 0;
}
