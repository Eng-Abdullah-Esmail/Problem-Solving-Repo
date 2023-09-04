#include<iostream>
using namespace std;

class TimeConverter {
private:
    int hours, minutes;
public:
    void convertSeconds(int seconds) {
        hours = seconds / 3600;
        minutes = (seconds % 3600) / 60;
    }
    void displayTime() {
        cout << "Time = " << hours << " hours " << minutes << " minutes" << endl;
    }
};

int main() {
    TimeConverter tc;
    int seconds;
    cout << "Enter time in seconds: ";
    cin >> seconds;
    tc.convertSeconds(seconds);
    tc.displayTime();
    return 0;
}