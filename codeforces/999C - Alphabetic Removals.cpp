#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
	int n, k, index, count[28] = { 0 }, remove[28] = { 0 };
	cin >> n >> k;

	string str;
	cin >> str;

	for (int i = 0; i < n; i++)
		count[str[i] - 'a']++;

	for (int i = 0; i < 28 && k > 0; i++)
		k -= (remove[i] = min(count[i], k));

	for (int i = 0; i < n; i++)
	{
		if (remove[str[i] - 'a'] == 0)
			cout << str[i];
		else if (remove[str[i] - 'a'] > 0)
			remove[str[i] - 'a']--;
	}

	cout << endl;

	return 0;
}
