#include <iostream>
using namespace std;

int main()
{
	int n, week_pages[7], pages_read = 0, finished_on = -1;
	cin >> n;

	for (int i = 1; i <= 7; i++)
		cin >> week_pages[i];

	while (finished_on == -1)
	{
		for (int i = 1; i <= 7; i++)
		{
			if ((pages_read += week_pages[i]) >= n && finished_on == -1)
				finished_on = i;
		}
	}

	cout << finished_on << endl;

	return 0;
}
