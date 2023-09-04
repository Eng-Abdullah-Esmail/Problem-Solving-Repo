#include<iostream>
#include<string>
using namespace std;



struct Max {
	int Number1;
	int Number2;
	int Number3;

};

Max ReadNumber() {
	Max Number;
	cout << "Enter first Number :" << endl;
	cin >> Number.Number1;

	cout << "Enter second Number  :" << endl;
	cin >> Number.Number2;

	cout << "Enter third Number  :" << endl;
	cin >> Number.Number3;



	return Number;
}

int IsMax(Max No) {
	if (No.Number1 > No.Number2 && No.Number1 > No.Number3)
		return No.Number1;
	else if (No.Number2 > No.Number1 && No.Number2 > No.Number3)
		return No.Number2;
	else
		return No.Number3;
}


void PrintMax(int max) {

	cout << "\n Max Number: " << max << endl;

}


int main() {

	PrintMax(IsMax(ReadNumber()));

	return 0;
}
