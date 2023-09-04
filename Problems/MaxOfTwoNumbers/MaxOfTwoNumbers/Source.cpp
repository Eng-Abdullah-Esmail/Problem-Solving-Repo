#include<iostream>
#include<string>
using namespace std;



struct Max {
	int Number1;
	int Number2;

};

Max ReadNumber() {
	Max Number;
	cout << "Enter first Number :" << endl;
	cin >> Number.Number1;

	cout << "Enter second Number  :" << endl;
	cin >> Number.Number2;



	return Number;
}

int IsMax(Max No) {
	if (No.Number1 > No.Number2)
		return No.Number1;
	else
		return No.Number2;
}


void PrintMax(int max) {

	cout << "\n Max Number: " << max << endl;

}


int main() {

	PrintMax(IsMax(ReadNumber()));

	return 0;
}
