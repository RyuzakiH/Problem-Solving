#include <iostream>
using namespace std;

int main()
{
	short w;
	cin >> w;

	cout << ((w % 2 == 0 && w > 2) ? "YES" : "NO");

	return 0;
}