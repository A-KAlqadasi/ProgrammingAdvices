#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;

bool IsDateInPeriod(stPeriod period, sDate date)
{
	return !(CompareDates(date, period.dateFrom) == enDateCompare::Before
		||
		CompareDates(date, period.dateTo) == enDateCompare::After);
}

int main()
{
	// is date within period
	cout << "Enter Period:\n";
	stPeriod period = ReadPeriod();

	cout << "\n\nEnter Date To Check:\n";
	sDate date = ReadFullDate();

	if (IsDateInPeriod(period, date))
	{
		cout << "\nYes Date is within period.\n";
	}
	else
	{
		cout << "\nNo, Date is not within period.\n";
	}


	system("pause>0");
	return 0;
}