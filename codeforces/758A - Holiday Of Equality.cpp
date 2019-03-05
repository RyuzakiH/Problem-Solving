#include <iostream>
#include <vector>
using namespace std;

int main()
{
	int n, max(0), num, i, addition(0);
	cin >> n;

	vector<int> nums;

	for (i = 0; i < n; i++)
	{
		cin >> num;
		nums.push_back(num);

		if (num > max)
			max = num;
	}

	for (i = 0; i < n; i++)
		addition += max - nums[i];

	cout << addition << endl;

	return 0;
}
