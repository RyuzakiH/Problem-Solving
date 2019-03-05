#include <iostream>
#include <string>
#include <map>
using namespace std;

int main()
{
	short n, cookies = 0, bag, ways = 0;
	cin >> n;

	map<int, int> bags;

	for (short i = 0; i < n; i++)
	{
		cin >> bag;
		cookies += bag;

		if (bags.count(bag) == 0)
			bags[bag] = 1;
		else
			bags[bag]++;
	}

	for (const auto& kv : bags)
		if ((cookies - kv.first) % 2 == 0)
			ways += kv.second;

	cout << ways << endl;

	return 0;
}