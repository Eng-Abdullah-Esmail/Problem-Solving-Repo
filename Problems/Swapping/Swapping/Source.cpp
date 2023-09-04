#include<iostream>
using namespace std;


void Swap(int& Num1, int& Num2) {

	int Temp = Num1;
	Num1 = Num2;
	Num2 = Temp;

}

void Print(int N1, int N2) {
	cout << "Value of number 1:  " << N1 << endl;
	cout << "Value of Number 2:  " << N2 << endl;
	cout << "\n\n";
}

int main() {

	int No1 = 30;
	int No2 = 40;
	Print(No1, No2);
	Swap(No1, No2);
	Print(No1, No2);

	return 0;
}
