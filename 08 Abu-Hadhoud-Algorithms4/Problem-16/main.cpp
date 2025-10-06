#include<iostream>
#include "MyDateLib.h"
using namespace std;

MyDateLib::sDate IncreaseDateByOneDay(MyDateLib::sDate date)
{
	if ( MyDateLib::IsLastDayInMonth(date) && MyDateLib::IsLastMonthInYear(date.month))
	{
		date.year++;
		date.month = 1;
		date.day = 1;
	}
	else if (MyDateLib::IsLastDayInMonth(date))
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

int main()
{
	// Adding one Day to Date
	MyDateLib::sDate date = MyDateLib::ReadFullDate();
	MyDateLib::sDate date2 = MyDateLib::IncreaseDateByOneDay(date);
	cout << "Date after adding one day: " 
		<< date2.day << "/" << date2.month << "/" << date2.year << endl;

	system("pause > 0");
}