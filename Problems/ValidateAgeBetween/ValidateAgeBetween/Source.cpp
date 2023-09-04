#include<iostream>
#include<string>
using namespace std;

int main() {
	cout << "\n validate age between \n" << endl;
	int Age;
	cout << "Enter Age: ";
	cin >> Age;
	if (Age > 18 && Age < 45)
		cout << "Valid Age \n";
	else
		cout << "Invalid Age \n";

	return 0;
}
