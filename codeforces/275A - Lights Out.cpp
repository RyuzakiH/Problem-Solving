#include <iostream>
using namespace std;

template <size_t rows, size_t cols>
void TryAddValue(int (&arr)[rows][cols], int i, int j, int value)
{
	if (i < rows && j < cols)
		arr[i][j] += value;
}

int main()
{
	int lights[3][3], additions[3][3]{ 0 };

	for (int i = 0; i < 3; i++)
		for (int j = 0; j < 3; j++)
			cin >> lights[i][j];

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			TryAddValue<3, 3>(additions, i + 1, j, lights[i][j]);
			TryAddValue<3, 3>(additions, i - 1, j, lights[i][j]);
			TryAddValue<3, 3>(additions, i, j + 1, lights[i][j]);
			TryAddValue<3, 3>(additions, i, j - 1, lights[i][j]);
		}
	}

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
			cout << !((lights[i][j] + additions[i][j]) % 2);
		cout << endl;
	}

	return 0;
}
