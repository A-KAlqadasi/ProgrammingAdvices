#include<iostream>
#include"MyDateLib.h"
using namespace std;
using namespace MyDateLib;

int PeriodLengthInDays(stPeriod period, bool includeEndDay = false)
{
	return GetDifferenceInDays(period.dateFrom, period.dateTo, includeEndDay);
}

int main()
{
	// get period length in days
	cout << "Enter Period 1:\n";
	stPeriod period = ReadPeriod();
	
	cout<<"\n\nPeriod Length is:"<< PeriodLengthInDays(period) <<endl;
	cout << "Period Length (Encluding last day) is: " << PeriodLengthInDays(period,true) << endl;
		 

	system("pause>0");
}