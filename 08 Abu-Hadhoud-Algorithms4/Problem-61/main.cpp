#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;

int CountOverlapDays(stPeriod period1, stPeriod period2)
{
	int period1Length = PeriodLengthInDays(period1, true);
	int period2Length = PeriodLengthInDays(period2, true);
	short overlapDays = 0;
	if (!IsOverlapPeriods(period1, period2))
		return 0;

	if (period1Length < period2Length)
	{
		while (IsDate1BeforeDate2(period1.dateFrom,period1.dateTo))
		{
			if (IsDateInPeriod(period2, period1.dateFrom))
				overlapDays++;

			period1.dateFrom = IncreaseDateByOneDay(period1.dateFrom);
		}
	}
	else
	{
		while (IsDate1BeforeDate2(period2.dateFrom, period2.dateTo))
		{
			if (IsDateInPeriod(period1, period2.dateFrom))
				overlapDays++;

			period2.dateFrom = IncreaseDateByOneDay(period2.dateFrom);
		}
	}
	
	return overlapDays;
}

int main()
{
	cout << "Enter Period 1:\n";
	stPeriod period1 = ReadPeriod();

	cout << "\n\nEnter Period 2:\n";
	stPeriod period2 = ReadPeriod();

	cout << "\nOverlap Days : " << CountOverlapDays(period1, period2) << endl;

	system("pause>0");
	return 0;
}