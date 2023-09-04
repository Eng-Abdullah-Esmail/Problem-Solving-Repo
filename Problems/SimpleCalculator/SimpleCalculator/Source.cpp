#include<iostream>
using namespace std;

int add(int a, int b) {
    return a + b;
}

int subtract(int a, int b) {
    return a - b;
}

int multiply(int a, int b) {
    return a * b;
}

int divide(int a, int b) {
    return a / b;
}

int main() {
    int a, b;
    char op;
    cout << "Enter two numbers: ";
    cin >> a >> b;
    cout << "Enter operator (+, -, *, /): ";
    cin >> op;
    switch (op) {
    case '+': cout << a << " + " << b << " = " << add(a, b) << endl; break;
    case '-': cout << a << " - " << b << " = " << subtract(a, b) << endl; break;
    case '*': cout << a << " * " << b << " = " << multiply(a, b) << endl; break;
    case '/': cout << a << " / " << b << " = " << divide(a, b) << endl; break;
    default: cout << "Invalid operator" << endl;
    }
    return 0;
}