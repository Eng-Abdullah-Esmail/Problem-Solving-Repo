#include<iostream>
#include<string>
using namespace std;

enum enMark {
	Pass = 1,
	Fail = 2
};

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


enMark IsPass(float Average) {
	if (Average >= 50)
		return enMark::Pass;
	else
		return enMark::Fail;
}

void PrintAverage(enMark Pass) {
	if (Pass == enMark::Pass)
		cout << "\n You passed " << endl;
	else
		cout << "\n You failed" << endl;
}


int main() {

	PrintAverage(IsPass(Average(SumOfMarks(ReadMarks()))));

	return 0;
}
