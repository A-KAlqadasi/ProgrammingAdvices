// Problem 35: Piggy bank calculator
#include<iostream>
using namespace std;

int ReadNumber(string message)
{
	short number = 0;
	cout << message << endl;
	cin >> number;
	return number;
}

int CalculateRemainder(int totalBill, int cashPaid)
{
	return cashPaid - totalBill;
}
int main()
{

	int totalBill = ReadNumber("Please enter totalBill? ");
	int cashPaid = ReadNumber("Please enter cash paid");

	int remainder = CalculateRemainder(totalBill,cashPaid);

	cout << "\nRemainder = " << remainder << endl;

	system("pause>0");
	return 0;
}