#include <iostream>
#include <map>
#include <vector>
#include <algorithm>
#include <string>
using namespace std;

unsigned int gcd(unsigned int n1, unsigned int n2)
{
	return (n2 == 0) ? n1 : gcd(n2, n1 % n2);
}

int main()
{
	int n, m, edges(0);
	cin >> n >> m;

	string output = "";

	if (m < n - 1)
	{
		cout << "Impossible\n";
		return 0;
	}

	bool done = false;
	for (int i = 1; i <= n && !done; i++)
	{
		for (int j = i + 1; j <= n && !done; j++)
		{
			if (gcd(i, j) == 1)
			{
				output += to_string(i) + " " + to_string(j) + "\n";
				done = (++edges >= m);
			}
		}
	}

	cout << (done ? "Possible\n" + output : "Impossible\n");

	return 0;
}