#include <iostream>
#include <string>
#include <algorithm> 
#include <functional> 
#include <cctype>
#include <locale>
using namespace std;

// trim from end (in place)
static inline void rtrim(std::string &s)
{
	s.erase(find_if(s.rbegin(), s.rend(), [](int ch) {
		return !isspace(ch);
	}).base(), s.end());
}

int main()
{
	int n;
	cin >> n;

	for (int i = 0; i <= n * 2; i++)
	{
		string s = "";

		for (int j = 0; j <= n * 2; j++)
		{
			int num = -1;
			if (i <= n && j <= n)
				num = i + j - n;
			else if (i <= n & j >= n)
				num = i - j + n;
			else if (i >= n & j <= n)
				num = -i + j + n;
			else if (i >= n & j >= n)
				num = -i - j + 3 * n;

			s.append((num < 0 ? " " : to_string(num)) + " ");
		}

		rtrim(s);
		cout << s << endl;
	}

	return 0;
}
