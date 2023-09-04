#include<iostream>
#include<cmath>
using namespace std;

int mostFrequent(int* arr, int n)
{
	// code here
	int maxcount = 0; //store the max occurence of the previous element
	int element_having_max_freq;
	for (int i = 0; i < n; i++) {
		int count = 0;
		for (int j = 0; j < n; j++) {
			if (arr[i] == arr[j])
				count++;
		}

		if (count > maxcount) {
			maxcount = count;
			element_having_max_freq = arr[i];
		}
	}

	return element_having_max_freq;
}


int Sum(int* arr, int n) {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		sum = sum + arr[i];
	}


	return sum;
}

bool IsEven(int number) {
	if (number % 2 == 0)
		return true;
	else
		return false;
}

// Driver program
int main()
{
	int median;
	int arr[] = { 40, 50, 30, 40, 50, 30, 30 };
	int arr2[] = { 40, 50, 60, 77, 80, 88, 90, 99, 109, 200,290,300 };
	int n = sizeof(arr) / sizeof(arr[0]);
	int n2 = sizeof(arr2) / sizeof(arr2[0]);
	cout << n2 << endl;
	//n2= n2-1;
//	cout << mostFrequent(arr, n);

	if (IsEven(n2)) {
		int middle = (n2 / 2);
		median = arr2[middle - 1] + arr2[middle + 1] / 2;

	}
	else
	{
		int middle = (n2 / 2);
		cout << middle << endl;
		median = arr2[middle];
	}

	cout << median << endl;
	return 0;
}



