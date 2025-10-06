#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;

short CalculateVacationDays(sDate dateFrom, sDate DateTo)
{
	short DaysCount = 0;
	while(IsDate1BeforeDate2(dateFrom,DateTo))
	{
		if (IsBusinessDay(dateFrom))
			DaysCount++;

		dateFrom = IncreaseDateByOneDay(dateFrom);
	}

	return DaysCount;
}

int main()
{      
	cout << "Vacation Starts:\n";
	sDate date1 = ReadFullDate();

	cout << "Vacation Ends:\n";
	sDate date2 = ReadFullDate();
	
	cout << "\n\nVacation From: " << DayShortName(DayOfWeekOrder(date1)) << " , ";
	cout << date1.day << "/" << date1.month << "/" << date1.year << endl;

	cout<<"Vacation To: " << DayShortName(DayOfWeekOrder(date2)) << " , ";
	cout << date2.day << "/" << date2.month << "/" << date2.year << endl;

	cout << "\n\nActual Vacation Days is: " << CalculateVacationDays(date1, date2) << endl;

	system("pause>0");
}
