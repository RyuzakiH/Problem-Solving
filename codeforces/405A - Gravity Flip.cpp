#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
	int n, a[100];
	cin >> n;

	for (int i = 0; i < n; i++)
		cin >> a[i];
	
	sort(begin(a), a + n);
	
	for (int i = 0; i < n; i++)
		cout << a[i] << " ";

	return 0;
}
