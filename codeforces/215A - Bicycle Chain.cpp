#include <iostream>
#include <vector>
#include <algorithm>
#include <functional>
using namespace std;

int main()
{
	int n, m, a[50], b[50];

	cin >> n;
	for (int i = 0; i < n; i++)
		cin >> a[i];

	cin >> m;
	for (int i = 0; i < m; i++)
		cin >> b[i];

	vector<int> v;

	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (b[i] % a[j] == 0)
				v.push_back(b[i] / a[j]);
		}
	}

	sort(v.begin(), v.end(), greater<int>());

	int max = v[0], count(0);

	for (; count < v.size() && v[count] == max; count++);

	cout << count << endl;

	return 0;
}
