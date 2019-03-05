#include <iostream>
using namespace std;

int main()
{
	long long N, K, half;
	cin >> N >> K;

	half = (N % 2 == 0) ? (N / 2) : (N / 2 + 1);

	cout << ((K <= half) ? 2 * K - 1 : 2 * (K - half)) << endl;

	return 0;
}
