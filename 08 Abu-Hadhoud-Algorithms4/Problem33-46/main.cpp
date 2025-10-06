#include<iostream>
using namespace std;
#include"MyDateLib.h"


bool IsFirstDayInMonth(short day)
{
	return day == 1;
}

bool IsFirstMonthInYear(short month)
{
	return month == 1;
}

MyDateLib::sDate DecreaseDateByOneDay(MyDateLib::sDate date)
{
	if (IsFirstDayInMonth(date.day) && IsFirstMonthInYear(date.month))
	{
		date.year--;
		date.day = 31;
		date.month = 12;
	}
	else if (date.day == 1)
	{
		date.month--;
		date.day = MyDateLib::NumberOfDaysInMonth(date.year, date.month);
	}
	else
	{
		date.day--;
	}

	return date;
}

MyDateLib::sDate DecreaseDateByXDays(MyDateLib::sDate date, short numOfDays)
{
	for (int i = 1; i <= numOfDays; i++)
	{
		date = DecreaseDateByOneDay(date);
	}

	return date;
}

MyDateLib::sDate DecreaseDateByOneWeek(MyDateLib::sDate date)
{
	for (short i = 7; i >= 1; i--)
	{
		date = DecreaseDateByOneDay(date);
	}
	return date;
}

MyDateLib::sDate DecreaseDateByXWeeks(MyDateLib::sDate date, short numOfWeeks)
{
	for (short i = numOfWeeks; i >= 1; i--)
	{
		date = DecreaseDateByOneWeek(date);
	}
	return date;
}

MyDateLib::sDate DecreaseDateByOneMonth(MyDateLib::sDate date)
{
	if (IsFirstMonthInYear(date.month))
	{
		date.year--;
		date.month = 12;
	}
	else
	{
		date.month--;
	}

	short numberOfDaysInMonth = MyDateLib::NumberOfDaysInMonth(date.year, date.month);
	if (date.day > numberOfDaysInMonth)
	{
		date.day = numberOfDaysInMonth;
	}

	return date;
}

MyDateLib::sDate DecreaseDateByXMonths(MyDateLib::sDate date, short numOfMonths)
{
	for (short i = numOfMonths; i >= 1; i--)
	{
		date = DecreaseDateByOneMonth(date);
	}
	return date;
}

MyDateLib::sDate DecreaseDateByOneYear(MyDateLib::sDate date)
{
	date.year--;
	return date;
}

MyDateLib::sDate DecreaseDateByXYears(MyDateLib::sDate date, short numOfYear)
{
	date.year -= numOfYear;
	return date;
}

MyDateLib::sDate DecreaseDateByOneDecade(MyDateLib::sDate date)
{
	date.year -= 10;
	return date;
}

MyDateLib::sDate DecreaseDateByXDecades(MyDateLib::sDate date, short numOfDecades)
{
	date.year -= numOfDecades * 10;
	return date;
}

MyDateLib::sDate DecreaseDateByOneCentury(MyDateLib::sDate date)
{
	date.year -= 100;
	return date;
}

MyDateLib::sDate DecreaseDateByOneMillennium(MyDateLib::sDate date)
{
	date.year -= 1000;

	return date;
}

int main()
{
	MyDateLib::sDate date = MyDateLib::ReadFullDate();
	cout << "\n\nDate After:\n\n";
	//01 decrease date by one day
	date = DecreaseDateByOneDay(date);
	cout << "01-Substracting one day is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//02 decrease date by x days
	short num = 10;
	date = DecreaseDateByXDays(date, num);
	cout <<"02-Substracting " << num <<" days is: "<< date.day << "/" << date.month << "/" << date.year << endl;
	//03 decrease date by one week
	date = DecreaseDateByOneWeek(date);
	cout << "03-Substracting one week is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//04 decrease date by x weeks
	date = DecreaseDateByXWeeks(date, num);
	cout << "04-Substracting " << num << " weeks is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//05 Decrease date by one month
	date = DecreaseDateByOneMonth(date);
	cout << "05-Substracting one month is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//06 Decrease date by x months
	num = 5;
	date = DecreaseDateByXMonths(date, num);
	cout << "06-Substracting " << num << " months is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//07 Decrease date by one year
	date = DecreaseDateByOneYear(date);
	cout << "07-Substracting one year is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//08 Decrease date by x years
	num = 10;
	date = DecreaseDateByXYears(date, num);
	cout << "08-Substracting " << num << " years is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//08 Decrease date by x years
	num = 10;
	date = DecreaseDateByXYears(date, num);
	cout << "08-Substracting " << num << " years is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//09 Decrease date by one decade
	date = DecreaseDateByOneDecade(date);
	cout << "09-Substracting one decade is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//10 Decrease date by x decades 
	num = 10;
	date = DecreaseDateByXDecades(date, num);
	cout << "10-Substracting " << num << " decades is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//10 Decrease date by x decades 
	num = 10;
	date = DecreaseDateByXDecades(date, num);
	cout << "10-Substracting " << num << " decades is: " << date.day << "/" << date.month << "/" << date.year << endl;
	// 11 Decrease date by one century
	date = DecreaseDateByOneCentury(date);
	cout << "11-Substracting one century is: " << date.day << "/" << date.month << "/" << date.year << endl;
	//12 Decrease date by one millennium
	date = DecreaseDateByOneMillennium(date);
	cout << "12-Substracting one Millennium is: " << date.day << "/" << date.month << "/" << date.year << endl;

	system("pause>0");
}