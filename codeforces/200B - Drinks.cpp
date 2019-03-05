#include <iostream>
using namespace std;

int main()
{
	int N, P[100], volume = 0;
	cin >> N;

	for (int i = 0; i < N; i++)
	{
		cin >> P[i];
		volume += P[i];
	}

	printf("%.12f\n", (double)volume / N);
	
	return 0;
}
