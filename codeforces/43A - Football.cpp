#include <iostream>
#include <string>
#include <map>
using namespace std;

int main()
{
	int n;
	cin >> n;

	string team;
	map<string, int> goals;
	pair<string, int> max;

	for (; n > 0; n--)
	{
		cin >> team;

		if (goals.count(team) > 0)
			goals[team]++;
		else
			goals[team] = 1;

		if (goals[team] > max.second)
			max = make_pair(team, goals[team]);
	}

	cout << max.first << endl;

	return 0;
}
