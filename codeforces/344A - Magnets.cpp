#include <iostream>
using namespace std;

int main()
{
	int n, m;
	cin >> n;
	
	int groups = 0, state = 0;
	
	for (int i = 0; i < n; i++)
	{
		cin >> m;
		
		if (state == 0)
			groups++;
		else if (state == 1 && m == 10)
		{
			groups++;
			state = 10;
		}
		else if (state == 10 && m == 1)
		{
			groups++;
			state = 1;
		}
		
		state = m;
	}
	
	cout << groups << endl;

	return 0;
}