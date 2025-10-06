#include<iostream>
//#include"MyDateLib.h"
using namespace std;
//using namespace MyDateLib;

struct sDate
{
	short year;
	short month;
	short day;
};

struct stPeriod
{
	sDate dateFrom;
	sDate dateTo;
};

short ReadDay()
{
	short day = 0;
	cout << "Please enter a day? ";
	cin >> day;

	return day;
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

short ReadYear()
{
	short year = 0;
	do
	{
		cout << "Please enter a year? ";
		cin >> year;

	} while (year < 0);

	return year;
}

sDate ReadFullDate()
{
	sDate date;
	date.day = ReadDay();
	date.month = ReadMonth();
	date.year = ReadYear();
	return date;
}

stPeriod ReadPeriod()
{
	stPeriod period;
	cout << "Enter Start Date\n\n";
	period.dateFrom = ReadFullDate();
	cout << "\n\nEnter End Date\n\n";
	period.dateTo = ReadFullDate();
	
	return period;
}

bool IsDate1EqualDate2(sDate date1, sDate date2)
{
	return (date1.year == date2.year) ? ((date1.month == date2.month) ? (date1.day == date2.day ? true : false) : false) : false;
}
bool IsDate1BeforeDate2(sDate date1, sDate date2)
{
	return (date1.year < date2.year) ? true : ((date1.year == date2.year) ? (date1.month < date2.month ? true : (date1.month == date2.month ? date1.day < date2.day : false)) : false);
}


enum enDateCompare { Before = -1, Equal = 0, After = 1 };

enDateCompare CompareDates(sDate date1, sDate date2)
{
	if (IsDate1BeforeDate2(date1, date2))
		return enDateCompare::Before;
	if (IsDate1EqualDate2(date1, date2))
		return enDateCompare::Equal;

	return enDateCompare::After;
}

bool IsOverlapPeriods(stPeriod period1, stPeriod period2)
{
	if (CompareDates(period2.dateFrom, period1.dateTo) == enDateCompare::After
		||
		CompareDates(period2.dateTo, period1.dateFrom) == enDateCompare::Before)
		return false;
	else
		return true;
}

int main()
{
	// is overlap periods 
	cout << "\nEnter Period 1:\n";
	stPeriod period1 = ReadPeriod();
	cout << "\nEnter Period 2:\n";
	stPeriod period2 = ReadPeriod();

	if (IsOverlapPeriods(period1, period2))
	{
		cout << "\n\nYes, Periods overlap." << endl;
	}
	else
	{
		cout << "\n\nNo, periods not overlap" << endl;
	}

	system("pause>0");
}