#include <iostream>
#include <string>
using namespace std;

void replaceAll(std::string& str, const std::string& from, const std::string& to)
{
	if (from.empty())
		return;
	size_t start_pos = 0;
	while ((start_pos = str.find(from, start_pos)) != std::string::npos)
	{
		str.replace(start_pos, from.length(), to);
		start_pos += to.length(); // In case 'to' contains 'from', like replacing 'x' with 'yx'
	}
}

int main()
{
	int N, T;
	cin >> N >> T;

	string queue;
	cin >> queue;
	
	for (; T > 0; T--)
		replaceAll(queue, "BG", "GB");
	
	cout << queue << endl;

	return 0;
}
