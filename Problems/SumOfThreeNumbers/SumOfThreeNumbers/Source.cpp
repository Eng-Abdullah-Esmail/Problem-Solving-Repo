#include<iostream>
#include<string>
using namespace std;

struct Sumation {
	int Number1;
	int Number2;
	int Number3;
};

Sumation ReadNumber() {
	Sumation Sum;
	cout << "Enter first number :" << endl;
	cin >> Sum.Number1;

	cout << "Enter second number :" << endl;
	cin >> Sum.Number2;

	cout << "Enter third number :" << endl;
	cin >> Sum.Number3;

	return Sum;
}

int SumOfThree(Sumation Sum) {
	return (Sum.Number1 + Sum.Number2 + Sum.Number3);
}

void PrintSum(int Sum) {

	cout << "\n Sumation of Three :" << Sum << endl;
}


int main() {

	PrintSum(SumOfThree(ReadNumber()));

	return 0;
}
