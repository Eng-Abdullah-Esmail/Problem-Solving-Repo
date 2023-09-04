#include<iostream>
#include<string>
using namespace std;

enum enMarkType {
	Pass = 1,
	Fail = 2
};

float ReadMark() {

	float Mark;
	cout << "\n Enter the mark : " << endl;
	cin >> Mark;

	return Mark;
}

enMarkType Check(float Mark) {

	if (Mark >= 50)
		return enMarkType::Pass;
	else
		return enMarkType::Fail;
}

void Print(enMarkType MarkType) {

	if (MarkType == enMarkType::Pass)
		cout << "\n Pass" << endl;
	else
		cout << "\n Fail " << endl;
}

int main() {
	Print(Check(ReadMark()));


	return 0;
}
