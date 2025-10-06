#include<iostream>
using namespace std;
#include<time.h>


struct sDate
{
	short year;
	short month;
	short day;
};

short ReadYear()
{
	short year = 0;
	cout << "Pleaes enter a year? ";
	cin >> year;

	return year;
}

short ReadDay(string message)
{
	short day = 0;
	cout << message;
	cin >> day;

	return day;
}

short ReadMonth()
{
	short      month = 0;
	do
	{
		cout << "Please enter a Month? ";
		cin >> month;
	} while (month < 1 || month >12);
	return     month;
}

sDate ReadFullDate()
{
	sDate date;
	date.day = ReadDay("Please enter a Day? ");
	date.month = ReadMonth();
	date.year = ReadYear();

	return date;
}

bool IsDate1BeforeDate2H(sDate date1, sDate date2)
{
	return (date1.year < date2.year) ? true : ((date1.year == date2.year) ? (date1.month < date2.month ? true : (date1.month == date2.month ? date1.day < date2.day : false)) : false);
}
bool IsLeapYear(short year)
{
	return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
}

short NumberOfDaysInMonth(short year, short month)
{
	int arr[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
	return (month == 2) ? (IsLeapYear(year) ? 29 : 28) : arr[month - 1];
}

bool IsLastDayInMonth(sDate date)
{
	return NumberOfDaysInMonth(date.year, date.month) == date.day;
}

bool IsLastMonthInYear(short month)
{
	return month == 12;
}

sDate GetSystemDate()
{
	sDate Date;
	time_t t = time(0);
	tm* now = localtime(&t);

	Date.year = now->tm_year + 1900;
	Date.month = now->tm_mon + 1;
	Date.day = now->tm_wday;
	return Date;

}

sDate IncreaseDateByOneDay(sDate date)
{
	if (IsLastDayInMonth(date) && IsLastMonthInYear(date.month))
	{
		date.year++;
		date.month = 1;
		date.day = 1;
	}
	else if (IsLastDayInMonth(date))
	{
		date.day = 1;
		date.month++;
	}
	else
	{
		date.day++;
	}

	return date;

}

int GetDifferenceInDays(sDate date1, sDate date2, bool includeEndDay = false)
{
	short days = 0;
	while (IsDate1BeforeDate2H(date1, date2))
	{
		days++;
		date1 = IncreaseDateByOneDay(date1);
	}
	return includeEndDay ? ++days : days;
}

int main()
{
	// Your Age In Days
	sDate date1 = ReadFullDate();
	cout << endl;
	sDate date2 = GetSystemDate();

	
	cout << "\n\nYour Age In Days is: " << GetDifferenceInDays(date1, date2,true) << " Day(s)";

	system("pause>0");
	return 0;
}

