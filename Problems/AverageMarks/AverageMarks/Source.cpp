#include<iostream>
#include<string>
using namespace std;

struct Marks {
	int Mark1;
	int Mark2;
	int Mark3;
};

Marks ReadMarks() {
	Marks Mark;
	cout << "Enter first mark :" << endl;
	cin >> Mark.Mark1;

	cout << "Enter second mark  :" << endl;
	cin >> Mark.Mark2;

	cout << "Enter third mark :" << endl;
	cin >> Mark.Mark3;

	return Mark;
}

int SumOfMarks(Marks Mark) {
	return (Mark.Mark1 + Mark.Mark2 + Mark.Mark3);
}

float Average(int Sum) {
	return (float)Sum / 3;
}

void PrintAverage(float Average) {

	cout << "\n Average of Three marks: " << Average << endl;
}


int main() {

	PrintAverage(Average(SumOfMarks(ReadMarks())));

	return 0;
}
