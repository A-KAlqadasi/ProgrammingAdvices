#include<iostream>
using namespace std;
#include"MyDateLib.h"

void SwapDates(MyDateLib::sDate& date1, MyDateLib::sDate& date2)
{
	MyDateLib::sDate Temp;
	Temp.year = date1.year;
	Temp.month = date1.month;
	Temp.day = date1.day;

	date1.year = date2.year;
	date1.month = date2.month;
	date1.day = date2.day;

	date2.year = Temp.year;
	date2.month = Temp.month;
	date2.day = Temp.day;
}

int GetDifferenceInDays(MyDateLib::sDate date1, MyDateLib::sDate date2, bool includeEndDay = false)
{
	short days = 0;
	short swapFlagValue = 1;
	if (!MyDateLib::IsDate1BeforeDate2(date1, date2))
	{
		// Swap Dates
		MyDateLib::SwapDates(date1, date2);
		swapFlagValue = -1;
	}
	while (MyDateLib::IsDate1BeforeDate2(date1, date2))
	{
		days++;
		date1 = MyDateLib::IncreaseDateByOneDay(date1);
	}

	return includeEndDay ? ++days * swapFlagValue: days;
}

int main()
{
	// difference between two dates in days, includeing 
	MyDateLib::sDate date1 = MyDateLib::ReadFullDate();
	cout << endl;
	MyDateLib::sDate date2 = MyDateLib::ReadFullDate();

	cout << "\n\nDifference is: " << MyDateLib::GetDifferenceInDays(date1, date2) << " Day(s)";
	cout << "\nDifference (Including End Day) is: " << MyDateLib::GetDifferenceInDays(date1, date2, true) << " Day(s).\n";

	system("pause>0");
	return 0;
}

