#include<iostream>
#include<string>

using namespace std;

struct stInfo {
	int Age;
	bool HasDrivingLicense;
	bool HasRecommendation;
};

stInfo ReadInfo() {

	stInfo Info;
	cout << "\nEnter your age :" << endl;
	cin >> Info.Age;

	cout << "\nDo you have driver license? " << endl;
	cin >> Info.HasDrivingLicense;

	cout << "\nDo you have recommendation? " << endl;
	cin >> Info.HasRecommendation;

	return Info;
}

bool IsAccepted(stInfo Info) {
	if (Info.HasRecommendation)
		return true;
	else
		return (Info.Age > 21 && Info.HasDrivingLicense);
}

void PrintInfo(stInfo Info) {

	if (IsAccepted(Info))
		cout << "\n Hired \n";
	else
		cout << "\n Rejected \n";
}


int main() {
	PrintInfo(ReadInfo());

	return 0;
}
