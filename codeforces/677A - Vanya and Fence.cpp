#include <iostream>
using namespace std;

int main()
{
	int n, h, a, width = 0;
	cin >> n >> h;

	for (int i = 0; i < n; i++)
	{
		cin >> a;
		width += (a > h ? 2 : 1);
	}

	cout << width << endl;

	return 0;
}
