#include <iostream>
#include <string>
using namespace std;

int main()
{
	int N;
	cin >> N;

	if (N % 2 != 0)
	{
		cout << "-1" << endl;
		return 0;
	}

	string permutation = "";

	for (int i = 1; i <= N; i += 2)
		permutation.append(std::to_string(i + 1) + " " + std::to_string(i) + " ");
	permutation.pop_back();

	cout << permutation << endl;

	return 0;
}
