#include<iostream>
using namespace std;
#include"MyDateLib.h"



int GetDifferenceInDays(MyDateLib::sDate date1, MyDateLib::sDate date2,bool includeEndDay = false)
{
	short days = 0;
	if (MyDateLib::IsDate1BeforeDate2(date1, date2))
	{
		while (MyDateLib::IsDate1BeforeDate2(date1, date2))
		{
			days++;
			date1 = MyDateLib::IncreaseDateByOneDay(date1);
		}

	}
	else
	{
		while (MyDateLib::IsDate1BeforeDate2(date2, date1))
		{
			days++;
			date2 = MyDateLib::IncreaseDateByOneDay(date2);
		}
		
	}
	

	return includeEndDay ? ++days:days;
}

int main()
{
	// difference between two dates in days
	MyDateLib::sDate date1 = MyDateLib::ReadFullDate();
	cout << endl;
	MyDateLib::sDate date2 = MyDateLib::ReadFullDate();

	cout << "\n\nDifference is: " << MyDateLib::GetDifferenceInDays(date1, date2) << " Day(s)";
	cout << "\nDifference (Including End Day) is: " << MyDateLib::GetDifferenceInDays(date1, date2,true) << " Day(s).\n";

	system("pause>0");
	return 0;
}

