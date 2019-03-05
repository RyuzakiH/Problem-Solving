#include <iostream>
#include <set>
using namespace std;

int main()
{
	short n, level, num, k = 0;
	cin >> n;

	set<int> levels;

	for (short i = 0; i < 2; i++)
	{
		cin >> num;

		for (short j = 0; j < num; j++)
		{
			cin >> level;
			levels.insert(level);
		}
	}
	
	cout << ((n == levels.size()) ? "I become the guy." : "Oh, my keyboard!") << endl;

	return 0;
}