#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
	int s, n, x, y;
	cin >> s >> n;

	vector<pair<short, short>> dragons;

	for (; n > 0; n--)
	{
		cin >> x >> y;
		dragons.push_back(std::make_pair(x, y));
	}

	sort(dragons.begin(), dragons.end(), [](auto &left, auto &right) { return (left.first < right.first) || (left.first == right.first && left.second > right.second); });

	for (int i = 0; i < dragons.size(); i++)
	{
		if (s > dragons[i].first)
		{
			s += dragons[i].second;
			dragons.erase(dragons.begin() + i--);
		}
		else
		{
			cout << "NO" << endl;
			break;
		}
	}

	if (!dragons.size())
		cout << "YES" << endl;

	return 0;
}
