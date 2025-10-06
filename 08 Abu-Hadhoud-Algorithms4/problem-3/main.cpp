#include<iostream>
using namespace std;

short ReadYear()
{
	short year = 0;
	do
	{
		cout << "Enter a year? ";
		cin >> year;

	} while (year < 0);
	
	return year;
}

bool IsLeapYear(short year)
{
	return (year % 400 == 0 || ( year % 4 == 0 && year %100 !=0));
}


int main()
{
	// Is leap year
	short year = ReadYear();

	if (IsLeapYear(year))
	{
		cout << "\nyear [" << year << "] is leap year" << endl;
	}
	else
	{
		cout << "\nyear [" << year << "] is not leap year" << endl;
	}

	system("pause >0");
}