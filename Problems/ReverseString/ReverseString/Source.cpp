#include<iostream>
#include<string>
using namespace std;

void printStringReverse(string s) {
    for (int i = s.length() - 1; i >= 0; i--) {
        cout << s[i];
    }
    cout << endl;
}

int main() {
    string s;
    cout << "Enter a string: ";
    getline(cin, s);
    printStringReverse(s);
    return 0;
}