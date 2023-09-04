#include<iostream>
#include<cmath>
using namespace std;


struct Rectangle {

	int A;
	int D;
};

void Message(string message) {

	cout << message << endl;
}

Rectangle ReadNumber() {

	Rectangle Rec;
	Message("Enter A");
	cin >> Rec.A;
	Message("Enter D");
	cin >> Rec.D;

	return Rec;

}



float Area(Rectangle Rect) {

	float area = Rect.A * sqrt((Rect.D * Rect.D) - (Rect.A * Rect.A));

	return (float)area;
}

void Print(float Area) {
	cout << "Area of Rectangle throught diagonal is:  " << Area << endl;

	cout << "\n\n";
}

int main() {

	Print(Area(ReadNumber()));

	return 0;
}
