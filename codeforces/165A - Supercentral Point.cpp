#include <iostream>
#include <vector>
#include <set>
using namespace std;

enum Neighbour { Right, Left, Lower, Upper, None };

class Point
{
	int X, Y;
	set<Neighbour> neighbours;

public:
	Point(int x, int y) { X = x; Y = y; }

	void CheckIfNeighbour(Point p)
	{
		Neighbour neighb = Neighbour::None;

		if (p.X == X)
			neighb = (p.Y > Y) ? Neighbour::Upper : (p.Y < Y) ? Neighbour::Lower : Neighbour::None;
		else if (p.Y == Y)
			neighb = (p.X > X) ? Neighbour::Right : (p.X < X) ? Neighbour::Left : Neighbour::None;

		if (neighb != Neighbour::None)
			neighbours.insert(neighb);
	}

	bool IsSupercentral() { return neighbours.size() == 4; }
};

int main()
{
	int n, a, b, count(0);
	cin >> n;

	vector<Point> coordinates;

	for (int i = 0; i < n; i++)
	{
		cin >> a >> b;
		coordinates.push_back(Point(a, b));
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			coordinates[i].CheckIfNeighbour(coordinates[j]);
		}
	}

	for (int i = 0; i < n; i++)
	{
		if (coordinates[i].IsSupercentral())
			count++;
	}

	cout << count << endl;

	return 0;
}