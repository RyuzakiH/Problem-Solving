#include <iostream>
using namespace std;

int main()
{
	long long n,m,a, l, w;
	cin >> n >> m >> a;

	l = (n % a == 0) ? (n / a) : ((n / a) + 1);
	w = (m % a == 0) ? (m / a) : ((m / a) + 1);

	cout << l * w;

	return 0;
}