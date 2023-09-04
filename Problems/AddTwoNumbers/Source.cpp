#include<iostream>
using namespace std;

struct TwoNumbers {
	int Num1, Num2;
};

TwoNumbers ReadTwoNumbers() {
	TwoNumbers t;
	cout << "Enter Number 1" << endl;
	cin >> t.Num1;
	
	cout << "Enter Number 2 " << endl;
	cin >> t.Num2;

	return t;
}

int AddTwoNumber(TwoNumbers t) {
	return (t.Num1 + t.Num2);
}

void PrintSumation(int sum) {
	cout << "Sumation of Two Numbers is : " << sum << endl;
}


int main() {

	PrintSumation(AddTwoNumber(ReadTwoNumbers()));
	return 0;
}