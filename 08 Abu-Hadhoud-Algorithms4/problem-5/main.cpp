#include<iostream>
using namespace std;


short ReadYear()
{
	short year = 0;
	cout << "Enter a year to check? ";
	cin >> year;

	return year;
}


bool IsLeapYear(short year)
{
	return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
}
short ReadMonth()
{
	short month = 0;
	do
	{
		cout << "Please enter a Month? ";
		cin >> month;
	} while (month < 1 || month >12);
	return month;
}

short NumberOfDaysInMonth(short year, short month)
{
	if (month == 2)
	{
		return IsLeapYear(year) ? 29 : 28;
	}

	// 1 ,3,5,7,8,10,12 
	//int arr[12] = { 31,0,31,30,31,30,31,31,30,31,30,31 };
	int arr31Days[7] = { 1 ,3,5,7,8,10,12 };
	for (short i = 0; i < 7; i++)
	{
		if (arr31Days[i] == month)
			return 31;
	}
	return 30;
}

int NumberOfHoursInMOnth(short year, short month)
{
	return NumberOfDaysInMonth(year, month) * 24;
}

int NumberOfMinutesIMonth(short year, short month)
{
	return NumberOfHoursInMOnth(year, month) * 60;
}

int NumberOfSecondsInMonth(short year, short month)
{
	return NumberOfMinutesIMonth(year, month) * 60;
}

int main()
{
	// Number of days,hours, minutes , seconds in month
	short year = ReadYear();
	short month = ReadMonth();
	cout << "\nNumber of Days    in Month [" << month << "] is " << NumberOfDaysInMonth(year, month) << endl;
	cout << "\nNumber of Hours   in Month [" << month << "] is " << NumberOfHoursInMOnth(year, month) << endl;
	cout << "\nNumber of Minutes in Month [" << month << "] is " << NumberOfMinutesIMonth(year, month) << endl;
	cout << "\nNumber of Seconds in Month [" << month << "] is " << NumberOfSecondsInMonth(year, month) << endl;

	system("pause>0");
}