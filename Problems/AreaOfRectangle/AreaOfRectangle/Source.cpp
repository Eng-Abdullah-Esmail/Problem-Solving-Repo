#include<iostream>
#include<string>
using namespace std;



struct Rectangle {
	int A;
	int B;


};

Rectangle ReadRectangle() {
	Rectangle Rect;
	cout << "Enter  A :" << endl;
	cin >> Rect.A;

	cout << "Enter B   :" << endl;
	cin >> Rect.B;



	return Rect;
}


float CalculateArea(Rectangle Rect) {
	return (Rect.A * Rect.B);
}

void PrintArea(float Area) {

	cout << "\n Area of the Rectangle: " << Area << endl;

}


int main() {

	PrintArea(CalculateArea(ReadRectangle()));

	return 0;
}
