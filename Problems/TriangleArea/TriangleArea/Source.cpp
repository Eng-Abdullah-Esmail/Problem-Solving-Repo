#include<iostream>
#include<cmath>
using namespace std;


struct Triangle {

	int A;
	int H;
};

void Message(string message) {

	cout << message << endl;
}

Triangle ReadNumber() {

	Triangle Tria;
	Message("Enter A");
	cin >> Tria.A;
	Message("Enter H");
	cin >> Tria.H;

	return Tria;

}



float Area(Triangle Tria) {

	float area = (Tria.A * Tria.H) / 2;

	return (float)area;
}

void Print(float Area) {
	cout << "Area of Triangle   is:   " << Area << endl;

	cout << "\n\n";
}

int main() {

	Print(Area(ReadNumber()));

	return 0;
}
