#include<iostream>
using namespace std;
#include"MyDateLib.h"


MyDateLib::sDate IncreaseDateByXDays(MyDateLib::sDate date, short numOfDays = 10)
{
	
	for (int i = 1; i <= numOfDays; i++)
	{
		date = MyDateLib::IncreaseDateByOneDay(date);
	}
	return date;
}

MyDateLib::sDate IncreaseDateByOneWeek(MyDateLib::sDate date)
{

	for (int i = 1; i <= 7; i++)
	{
		date =  MyDateLib::IncreaseDateByOneDay(date);
	}
	return date;
}

MyDateLib::sDate IncreaseDateByXWeeks(MyDateLib::sDate date, short numOfWeeks)
{
	for (int i = 1; i <= numOfWeeks; i++)
	{
		date = IncreaseDateByOneWeek(date);
	}
	return date;
}

MyDateLib::sDate IncreaseDateByOneMonth(MyDateLib::sDate date)
{
	if (MyDateLib::IsLastMonthInYear(date.month))
	{
		date.month = 1;
		date.year++;
	}
	else
	{
		date.month++;
	}
	// check the ends of the months
	short numberOfDaysInMonth = MyDateLib::NumberOfDaysInMonth(date.year, date.month);
	if (date.day > numberOfDaysInMonth)
	{
		date.day = numberOfDaysInMonth;
	}

	return date;
}

MyDateLib::sDate IncreaseDateByXMonths(MyDateLib::sDate date, short numOfMonths )
{
	for (int i = 1; i <= numOfMonths; i++)
	{
		date = IncreaseDateByOneMonth(date);
	}
	return date;
}

MyDateLib::sDate IncreaseDateByOneYear(MyDateLib::sDate date)
{
	date.year++;
	return date;
}

MyDateLib::sDate IncreaseDateByXYears(MyDateLib::sDate date, short numOfYears)
{
	date.year += numOfYears;
	return date;
}

MyDateLib::sDate IncreaseDateByOneDecade(MyDateLib::sDate date)
{
	date.year += 10;
	return date;
}

MyDateLib::sDate IncreaseDateByXDecade(MyDateLib::sDate date,short numOfDecades)
{
	date.year += numOfDecades * 10;	
	return date;
}

MyDateLib::sDate IncreaseDateByOneCentury(MyDateLib::sDate date)
{
	date.year += 100;
	return date;
}

MyDateLib::sDate IncreaseDateByOneMillennim(MyDateLib::sDate date)
{
	date.year += 1000;
	return date;
}

int main()
{
	MyDateLib::sDate date = MyDateLib::ReadFullDate();

	cout << "\n\nDate After:\n\n";
	//01 increase date by one day
	MyDateLib::sDate date1 = MyDateLib::IncreaseDateByOneDay(date);
	cout << "01-Adding One Day is : "<< date1.day <<"/"<<date1.month <<"/"<<date1.year <<endl;

	// 02 increase date by x day
	short numOfDays = 10;
	MyDateLib::sDate date2 = IncreaseDateByXDays(date1,numOfDays);
	cout <<"02-Adding "<< numOfDays <<" days is : "<< date2.day << "/" << date2.month << "/" << date2.year << endl;
	
	//03 Increase date by one week
	MyDateLib::sDate date3 = IncreaseDateByOneWeek(date2);
	cout << "03-Adding  one week is: " << date3.day << "/" << date3.month << "/" << date3.year << endl;
	//04 Increase date by x weeks
	short numOfWeeks = 10;
	MyDateLib::sDate date4 = IncreaseDateByXWeeks(date3, numOfWeeks);
	cout << "04-Adding " << numOfWeeks << " weeks is : " << date4.day << "/" << date4.month << "/" << date4.year << endl;
	
	//05 Increase date by one month
	MyDateLib::sDate date5 = IncreaseDateByOneMonth(date4);
	cout << "05-Adding one month is: " << date5.day << "/" << date5.month << "/" << date5.year << endl;

	//06 Increase date by x Months
	short numOfMonths = 5;
	MyDateLib::sDate date6 = IncreaseDateByXMonths(date5, numOfMonths);
	cout << "06-Adding " << numOfMonths << " months is : " << date6.day << "/" << date6.month << "/" << date6.year << endl;
	
	//07 Increase date by one year
	MyDateLib::sDate date7 = IncreaseDateByOneYear(date6);
	cout << "07-Adding one year is: " << date7.day << "/" << date7.month << "/" << date7.year << endl;

	//08 Increase date by X years 
	short numOfYears = 10;
	MyDateLib::sDate date8 = IncreaseDateByXYears(date7, numOfYears);
	cout << "8-Adding " << numOfYears << " years is : " << date8.day << "/" << date8.month << "/" << date8.year << endl;
	
	//09 Increase date by one decade
	MyDateLib::sDate date9 = IncreaseDateByOneDecade(date8);
	cout << "09-Adding one decade is: " << date9.day << "/" << date9.month << "/" << date9.year << endl;

	// 10 Increase date by X decades
	short numOfDecades = 10;
	MyDateLib::sDate date10 = IncreaseDateByXDecade(date9, numOfDecades);
	cout << "10-Adding " << numOfDecades << " decades is : " << date10.day << "/" << date10.month << "/" << date10.year << endl;
	
	// 11 Increase date by one century
	MyDateLib::sDate date11 = IncreaseDateByOneCentury(date10);
	cout << "11-Adding one century is: " << date11.day << "/" << date11.month << "/" << date11.year << endl;

	//Increase date by one millennim 
	MyDateLib::sDate date12 = IncreaseDateByOneMillennim(date11);
	cout << "12-Adding one Millennim is: " << date12.day << "/" << date12.month << "/" << date12.year << endl;
	
	
	system("pause>0");
}