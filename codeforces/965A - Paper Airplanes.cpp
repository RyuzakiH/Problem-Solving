#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	int k, n, s, p;
	cin >> k >> n >> s >> p;

	cout << (int)ceil(ceil(n / (double)s) * k / (double)p) << endl;

	return 0;
}
