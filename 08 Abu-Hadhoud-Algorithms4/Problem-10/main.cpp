#include<iostream>

using namespace std;


short ReadYear()
{
	short year = 0;
	cout << "Enter a year? ";
	cin >> year;

	return year;
}
short ReadDay()
{
	short day = 0;
	cout << "Enter a day? ";
	cin >> day;

	return day;
}

short ReadMonth()
{
	short      month = 0;
	do
	{
		cout << "Please enter a Month to check? ";
		cin >> month;
	} while (month < 1 || month >12);
	return     month;
}

bool IsLeapYear(short year)
{
	return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
}

short NumberOfDaysInMonth(short year, short month)
{
	int arr[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
	return (month == 2) ? (IsLeapYear(year) ? 29 : 28) : arr[month - 1];
}

short NumberOfDaysFromBeginningOfYear(short year, short month, short day)
{
	short totalDays = day;
	for (int i = 1; i < month; i++)
	{
		totalDays += NumberOfDaysInMonth(year, i);
	}
	return totalDays;
}

int main()
{
	// Number of days from the beginning of the year
	short day = ReadDay();
	short month = ReadMonth();
	short year = ReadYear();

	cout << "Total Number of Days from beginning of year: " << NumberOfDaysFromBeginningOfYear(year, month, day) << endl;


	system("pause >0");
}