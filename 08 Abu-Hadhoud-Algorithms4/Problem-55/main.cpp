#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;

sDate CalculateEndVacationDate(sDate dateFrom, short vacationDays)
{
	short WeekEndCounter = 0;

	// if the first date is weekend increase until the first business date
	while (IsWeekEnd(dateFrom))
	{
		dateFrom = IncreaseDateByOneDay(dateFrom);
	}

	for (short i = 1; i <= vacationDays + WeekEndCounter; i++)
	{
		// here we add the vacation dates to add all weekends 
		if (IsWeekEnd(dateFrom))
		{
			WeekEndCounter++;
		}

		dateFrom = IncreaseDateByOneDay(dateFrom);
	}
	
	//in case the return date is weekend keep adding one day until you reach business day
	while (IsWeekEnd(dateFrom))
	{
		dateFrom = IncreaseDateByOneDay(dateFrom);
	}

	return dateFrom; 
}

int main()
{
	cout << "\nVacation Starts:\n";
	sDate dateFrom = ReadFullDate();

	cout << "Enter Vacation days? ";
	short vacationDays;
	cin >> vacationDays;
	sDate dateTo = CalculateEndVacationDate(dateFrom, vacationDays);

	cout << "\n\n\nReturn Date: " << DayShortName(DayOfWeekOrder(dateTo)) << ", ";
	cout << dateTo.day << "/" << dateTo.month << "/" << dateTo.year << endl;

	system("pause>0");
}