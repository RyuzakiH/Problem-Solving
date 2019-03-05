#include <iostream>
using namespace std;

int main()
{
	int n, f, fingers(0), ways(0);
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		cin >> f;
		fingers += f;
	}
	
	for (int i = 1; i <= 5; i++)
	{
		if ((fingers + i) % (n + 1) != 1)
			ways++;
	}

	cout << ways << endl;

	return 0;
}
