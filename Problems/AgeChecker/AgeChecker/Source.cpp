#include<iostream>
using namespace std;

class AgeChecker {
private:
    int age;
public:
    void setAge(int a) {
        age = a;
    }
    void checkAge() {
        if (age >= 18) {
            cout << "You are an adult" << endl;
        }
        else {
            cout << "You are a child" << endl;
        }
    }
};

int main() {
    AgeChecker ac;
    int age;
    cout << "Enter your age: ";
    cin >> age;
    ac.setAge(age);
    ac.checkAge();
    return 0;
}