#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;


bool IsValidDate2(sDate date)
{
	if (date.day < 1 || date.day>31)
		return false;

	if (date.month < 1 || date.month>12)
		return false;

	if (date.month ==2)
	{
		if (IsLeapYear(date.year))
		{
			if (date.day > 29)
				return false;
		}
		else
		{
			if (date.day > 28)
				return false;
		}
	}

	short numOfDaysInMonth = NumberOfDaysInMonth(date.year, date.month);

	if (date.day > numOfDaysInMonth)
		return false;

	return true;
}

bool IsValidDate(sDate date)
{
	short numOfDaysInMonth = NumberOfDaysInMonth(date.year, date.month);
	if ((date.day>=1 && date.day <= numOfDaysInMonth) 
		  && 
		(date.month >=1 && date.month<=12))
	{
		return true;
	}
	
	return false;
}


int main()
{
	// validate date
	sDate date = ReadFullDate();

	if (IsValidDate(date))
	{
		cout << "\nYes, It's Valid Date.\n";
	}
	else
	{
		cout << "\nNo, It is not valid date.\n";
	}

	system("pause>0");
	return 0;
}