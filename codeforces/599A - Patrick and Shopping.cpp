#include <iostream>
using namespace std;

int main()
{
	int d1, d2, d3, path;
	cin >> d1 >> d2 >> d3;

	if (d3 > (d1 + d2))
		path = 2 * d1 + 2 * d2;
	else if (d1 > (d3 + d2))
		path = 2 * d2 + 2 * d3;
	else if (d2 > (d3 + d1))
		path = 2 * d1 + 2 * d3;
	else
		path = d1 + d2 + d3;

	cout << path << endl;

	return 0;
}