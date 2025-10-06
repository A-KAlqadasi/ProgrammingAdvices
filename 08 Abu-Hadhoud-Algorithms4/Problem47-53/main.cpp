#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;


bool IsEndOfWeek(sDate date)
{
	return DayOfWeekOrder(date) == (short)6;
}

bool IsWeekEnd(sDate date)
{
	// weekend Fri and Sat
	short dayIndex = DayOfWeekOrder(date);
	return (dayIndex == 5 || dayIndex ==6);
}

bool IsBusinessDay(sDate date)
{
	return !IsWeekEnd(date);
}

short DaysUntilEndOfWeek(sDate date)
{
	return 6 - DayOfWeekOrder(date);
}

short DaysUntilEndOfMonth(sDate date)
{
	return NumberOfDaysInMonth(date.year, date.month) - date.day;
}

short DaysUntilEndOfYear(sDate date)
{
	short numOfDaysInYear = MyDateLib::NumberOfDaysInYear(date.year);
	short numOfDaysFromBegginingOfYear = MyDateLib::NumberOfDaysFromBeginningOfYear(date.year, date.month, date.day);

	return numOfDaysInYear - numOfDaysFromBegginingOfYear;
}

void PrintDateInfo(sDate date)
{
	short dayOrder = DayOfWeekOrder(date);
	string dayName = DayShortName(dayOrder);

	cout << "\nToday is " << dayName << ", " << date.day << "/" << date.month << "/" << date.year << endl;
	//---------------------
	cout << "\n\nIs it End of Week?\n";
	if (IsEndOfWeek(date))
	{
		cout << "Yes, It is End Of Week\n";
	}
	else
	{
		cout << "No, It isn't End of Week\n";
	}
	//--------------------------
	cout << "\n\nIs it WeekEnd?\n";
	if (IsWeekEnd(date))
	{
		cout << "Yes, It is Weekend\n";
	}
	else
	{
		cout << "No, It Is NOT a Weekend\n";
	}
	//---------------------------
	cout << "\n\nIs it Business Day?\n";
	if (IsBusinessDay(date))
	{
		cout << "Yes, It is Business Day\n";
	}
	else
	{
		cout << "No, It is NOT Business Day\n";
	}
	//---------------------------
	cout << "\n\nDays unitl end of week : " << DaysUntilEndOfWeek(date) << " Day(s).\n";
	cout << "Days until end of month: " << DaysUntilEndOfMonth(date) << " Day(s).\n";
	cout << "Days until end of year  :" << DaysUntilEndOfYear(date) << " Day(s)." << endl;

}

int main()
{
	MyDateLib::sDate date = GetSystemDate();

	PrintDateInfo(date);


	system("pause>0");
}