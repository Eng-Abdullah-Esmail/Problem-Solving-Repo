#include<iostream>
using namespace std;

void printMultiplicationTable(int n) {
    for (int i = 1; i <= 10; i++) {
        cout << n << " x " << i << " = " << n * i << endl;
    }
}

int main() {
    int n;
    cout << "Enter a number: ";
    cin >> n;
    printMultiplicationTable(n);
    return 0;
}