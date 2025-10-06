#include<iostream>
#include"MyDateLib.h"
using namespace std;


bool IsLastDayInMonth(short year,short month ,short day)
{
	return MyDateLib::NumberOfDaysInMonth(year, month) == day;
}

bool IsLastMonthInYear(short month)
{
	return month == 12;
}

int main()
{
	// Is Last Date In Month , Is last date in Year
	MyDateLib::sDate date = MyDateLib::ReadFullDate();

	if (IsLastDayInMonth(date.year, date.month, date.day) )
		cout << "\nYes Day Is Last day in Month\n";
	else
		cout << "\nNo, Day Isn't Last day in Month\n";
	// ------
	if(IsLastMonthInYear(date.month))
		cout << "\nYes Month Is Last month in Year\n";
	else
		cout << "\nNo, Month Isn't Last month in Year\n";

	


	system("pause > 0");
}