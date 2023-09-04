#include<iostream>
using namespace std;
int Day = 24 * 60 * 60;
int Hour = 60 * 60;
int Miniute = 60;

struct Task {
	int Days;
	int Hours;
	int Minutes;
	int Seconds;
};

Task Read() {
	Task T;
	cout << "Enter Days: " << endl;
	cin >> T.Days;
	cout << "Enter Hours: " << endl;
	cin >> T.Hours;
	cout << "Enter mins; " << endl;
	cin >> T.Minutes;
	cout << "Enter Seconds: " << endl;
	cin >> T.Seconds;

	return T;
}


int DaysToSeconds(int Days) {
	return Days * 24 * 60 * 60;
}

int HoursToSeconds(int Hours) {
	return Hours * 60 * 60;
}

int MinToSeconds(int Mins) {
	return Mins * 60;
}

int TotalSeconds(Task task) {

	int Total = task.Days * Day + task.Hours * Hour + task.Minutes * Miniute + task.Seconds;
	return Total;
}


int main() {

	cout << "Seconds:" << TotalSeconds(Read());
	return 0;
}
