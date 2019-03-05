#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
	int color;
	vector<int> shoes;

	for (int i = 0; i < 4; i++)
	{
		cin >> color;

		if (!(std::find(shoes.begin(), shoes.end(), color) != shoes.end()))
		{
			shoes.push_back(color);
		}
	}

	cout << (4 - shoes.size()) << endl;
	
	return 0;
}
