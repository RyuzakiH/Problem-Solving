#include <iostream>
#include <string>
#include <map>
using namespace std;

int main()
{
	int n;
	cin >> n;

	string name;
	map<string, int> database;

	for (int i = 0; i < n; i++)
	{
		cin >> name;

		if (database.count(name) == 0)
		{
			database[name] = 0;
			cout << "OK" << endl;
		}
		else
			cout << name << ++database[name] << endl;
	}

	return 0;
}