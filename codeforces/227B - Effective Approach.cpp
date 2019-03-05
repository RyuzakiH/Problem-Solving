#include <iostream>
#include <map>
using namespace std;

int main()
{
	long long n, m, b, vasya(0), petya(0), temp, i;
	map<long long, long long> a;

	cin >> n;
	for (i = 0; i < n; i++)
	{
		cin >> temp;
		a.insert(make_pair(temp, i + 1));
	}

	cin >> m;
	for (i = 0; i < m; i++)
	{
		cin >> b;

		vasya += a[b];
		petya += a.size() - a[b] + 1;
	}

	cout << vasya << " " << petya << endl;

	return 0;
}
