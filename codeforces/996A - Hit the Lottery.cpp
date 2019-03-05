#include <iostream>
using namespace std;

int main()
{
	int n, bills[] = { 100,20,10,5,1 }, count(0);
	cin >> n;

	for (int i = 0; n > 0; i++)
	{
		count += n / bills[i];
		n = n % bills[i];
	}

	cout << count << endl;

	return 0;
}
