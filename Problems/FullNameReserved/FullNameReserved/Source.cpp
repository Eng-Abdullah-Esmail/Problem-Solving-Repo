#include<iostream>
#include<string>

using namespace std;

struct stInfo {
	string FirstName;
	string LastName;
};

stInfo ReadInfo() {
	stInfo Info;
	cout << "\n Enter first name: " << endl;
	cin >> Info.FirstName;

	cout << "\n Enter last name: " << endl;
	cin >> Info.LastName;

	return Info;
}

string GetFullName(stInfo Info, bool Reversed) {
	string FullName = "";
	if (Reversed)
		FullName = Info.LastName + " " + Info.FirstName;
	else
		FullName = Info.FirstName + " " + Info.LastName;

	return FullName;
}

void PrintFullName(string Name) {
	cout << "\n Full Name : " << Name << endl;
}


int main() {

	PrintFullName(GetFullName(ReadInfo(), true));
	return 0;
}
