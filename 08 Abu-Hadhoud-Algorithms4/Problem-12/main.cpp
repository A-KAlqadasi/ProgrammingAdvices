#include <iostream>
using namespace std;


short ReadYear()
{
	short year = 0;
	cout << "Enter a year? ";
	cin >> year;

	return year;
}
short ReadDay(string message)
{
	short day = 0;
	cout << message ;
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
sDate AddDaysToDate(short Days, sDate date)
{
	
	short remainingDays = Days + NumberOfDaysFromBeginningOfYear(date.year, date.month, date.day);
	short monthsDays = 0;
	date.month = 1;

	while (true)
	{
		monthsDays = NumberOfDaysInMonth(date.year, date.month);

		if (remainingDays > monthsDays)
		{
			remainingDays -= monthsDays;
			date.month++;

			if (date.month > 12)
			{
				date.year++;
				date.month = 1;
			}
		}
		else
		{
			date.day = remainingDays;
			break;
		}
	}
	return date;
}
struct sDate
{
	short year;
	short month;
	short day;
};
sDate ReadFullDate()
{
	sDate date;
	date.day = ReadDay("Please enter a Day? ");
	date.month = ReadMonth();
	date.year = ReadYear();
	return date;
}

int main()
{
	// Add Days to Dates
	sDate date = ReadFullDate();
	short days = ReadDay("How many days to add? ");

	date = AddDaysToDate(days, date);
	
	cout << "Date After adding [" << days << "] is: ";
	cout << date.day << "/" << date.month << "/" << date.year << endl;


	system("pause>0");
}