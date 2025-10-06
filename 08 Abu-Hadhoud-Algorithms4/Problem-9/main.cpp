#include<iostream>
#include "MyInputLib.h"
#include <string>
using namespace std;

bool IsLeapYear(short year)
{
	return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
}

short NumberOfDaysInMonth(short year, short month)
{
	int arr[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
	return (month == 2) ? (IsLeapYear(year) ? 29 : 28) : arr[month - 1];
}
short DayOfWeekOrder(short year, short month, short day = 1)
{
	short a = (14 - month) / 12;
	short y = year - a;
	short m = month + 12 * a - 2;

	return ((day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7);
}

string MonthShortName(int monthNumber)
{
	string monthArr[12] = { "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" };
	return monthArr[monthNumber - 1];
}

void PrintMonthCalender(short year, short month)
{

	short monthDays = NumberOfDaysInMonth(year, month);
	short current = DayOfWeekOrder(year, month, 1);

	//cout << "\n  __________________" << MonthShortName(month) << "_______________\n\n";
	/*cout << "   " << "Sun" << "   " << "Mon" << "   " << "Tue" << "   " << "Wed" << "   "
		<< "Thu" << "   " << "Fri" << "   " << "Sat   \n";*/
	printf("\n  ______________%s______________\n\n", MonthShortName(month).c_str());
	printf("  Sun  Mon  Tue  Wed  Thu  Fri  Sat\n");
	int i;
	for (i = 0; i < current; i++)
	{
		printf("     ");
	}

	for (int j = 1; j <= monthDays; j++)
	{

		printf("%5d", j);
		if (++i == 7)
		{
			i = 0;
			printf("\n");

		}
	}
	cout << "\n  _______________________________" << endl;

}

void PrintYearCalender(short year)
{
	cout << "\n\n";
	cout << "\t\t________________________________\n";
	cout << "\t\t                                \n";
	cout << "\t\t     Calender - " << year <<   "\n";
	cout << "\t\t________________________________\n\n";


	for (int i = 1; i <= 12; i++)
	{
		PrintMonthCalender(year, i);
	}


}

int main()
{
	// Print Year Calender
	short year = MyInputLib::ReadYear();
	
	PrintYearCalender(year);


	system("pause > 0");
}