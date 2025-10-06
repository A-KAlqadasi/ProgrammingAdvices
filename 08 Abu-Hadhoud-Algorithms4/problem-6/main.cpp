#include<iostream>
using namespace std;


short ReadYear()
{
	short year = 0;
	cout << "Enter a year to check? ";
	cin >> year;

	return year;
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
	return (month == 2)?(IsLeapYear(year) ? 29 : 28) : arr[month - 1];
}

int main()
{
	// Number Of Days in Month
	short year = ReadYear();
	short month = ReadMonth();
	cout << "Number of days in month[" << month << "] is " << NumberOfDaysInMonth(year, month) << endl;


	system("pause>0");
}