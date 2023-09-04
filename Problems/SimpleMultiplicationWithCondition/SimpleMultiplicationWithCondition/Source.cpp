#include<iostream>
#include<string>
using namespace std;

int ReadNumber(string msg) {
	int num;
	cout << msg << endl;
	cin >> num;

	return num;
}

int PerformMultiplication(int num) {
	if (num % 2 == 0)
		return num * 8;
	else
		return num * 3;
}

//Alternate function
int PerformMultiplication2(int num) {
	return (num %2==0) ? num*8 : num*3 ;
}



void PrintResult(int result) {
	cout << "Result: " << result<<endl;
}


int main() {

	PrintResult(PerformMultiplication(ReadNumber("Enter a number")));

	return 0;
}