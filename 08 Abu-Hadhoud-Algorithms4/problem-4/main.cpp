#include<iostream>
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
	return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
}

int NumberOfDaysInYear(short year)
{
	return IsLeapYear(year) ? 366 : 365;
}

int NumberOfHoursInYear(short year)
{
	return NumberOfDaysInYear(year) * 24;
}

int NumberOfMinutesInYear(short year)
{
	return NumberOfHoursInYear(year) * 60;
}

int NumberOfSecondsInYear(short year)
{
	return NumberOfMinutesInYear(year) * 60;
}


int main()
{
	// number of days, hours, minutes, seconds in a year
	short year = ReadYear();
	cout << "\nNumber of days in year: " << NumberOfDaysInYear(year) << endl;
	cout << "\nNumber of Hours in year: " << NumberOfHoursInYear(year) << endl;
	cout << "\nNumber of Minutes in year: " << NumberOfMinutesInYear(year) << endl;
	cout << "\nNumber of Seconds in year: " << NumberOfSecondsInYear(year) << endl;


	system("pause>0");
}