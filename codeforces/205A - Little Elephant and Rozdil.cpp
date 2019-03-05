#include <iostream>
#include <string>
using namespace std;

int main()
{
	long n, t;
	cin >> n;
	//   min      index, count
	pair<long, pair<long, long>> min;
	min.first = LONG_MAX;

	for (long i = 1; i <= n; i++)
	{
		cin >> t;

		if (t < min.first)
		{
			min.first = t;
			min.second.first = i;
			min.second.second = 1;
		}
		else if (t == min.first)
		{
			min.second.second++;
		}
	}

	cout << (min.second.second == 1 ? std::to_string(min.second.first) : "Still Rozdil") << endl;

	return 0;
}
