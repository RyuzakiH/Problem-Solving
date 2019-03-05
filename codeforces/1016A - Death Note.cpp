#include <iostream>
using namespace std;

int main()
{
	long long n, m, a, page = 0, newPage, count = 0;
	
	cin >> n >> m;

	for (int i = 0; i < n; i++)
	{
		cin >> a;

		count += a;

		newPage = count / m;

		cout << (newPage - page) << " ";

		page = newPage;
	}

	return 0;
}
