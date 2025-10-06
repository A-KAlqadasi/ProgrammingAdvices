#include <iostream>
using namespace std;

short ReadYear() 
{
	short year = 0;
		cout << "Enter a year? ";
		cin >> year;

	return year;
}

bool IsLeapYear(short year)
{
	if (year % 400 == 0)
	{
		return true;
	}
	if (year % 4 == 0 && year % 100 != 0)
	{
		return true;
	}
	return false;
}

int main()
{
	// is leap year
	short year = ReadYear();
	if (IsLeapYear(year)) 
	{
		cout << year <<" is leap year" << endl;
	}
	else
	{
		cout << year <<" is not leap year" << endl;
	}

	system("pause >0");
}