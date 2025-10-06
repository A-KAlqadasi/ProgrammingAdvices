#pragma once

#include <iostream>
#include<time.h>
using namespace std;
#pragma warning(disable : 4996)

namespace MyDateLib
{
	struct sDate
	{
		short year;
		short month;
		short day;
	};
	int ReadNumber()
	{
		cout << "Enter a number? ";
		int number;
		cin >> number;
		return number;
	}

	string NumberToText(int number)
	{
		if (number == 0)
		{
			return " ";
		}
		if (number >= 1 && number <= 19)
		{
			string arr[] = { "","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Eleven","Tweleve"
							"Thirteen","Fourteen","Fifteen","Sixteen","Sixteen","Seventeen","Eeighteen","Nineteen" };
			return arr[number];
		}
		if (number >= 20 && number <= 99)
		{
			string arr[] = { "","","Twinty","Thirty","Fourty","Fifty","Sixty","Seventy","Eighty","Ninety" };
			return arr[number / 10] + " " + NumberToText(number % 10);
		}

		if (number >= 100 && number <= 199) {
			return "One Hundred " + NumberToText(number % 100);
		}

		if (number >= 200 && number <= 999)
		{
			string arr[] = { "","","Two Hundred","Three Hundred" ,"Four Hundred","five Hundred","Six Hundred","Seven Hundred","Eight Hundred","Nine Hundred" };

			return arr[number / 100] + " " + NumberToText(number % 100);
		}

		if (number >= 1000 && number <= 1999)
		{
			return "One Thousand " + NumberToText(number % 1000);
		}

		if (number >= 200 && number <= 999999)
		{
			return NumberToText(number / 1000) + " Thousands " + NumberToText(number % 1000);
		}

		if (number >= 1000000 && number <= 9999999)
		{
			return "One Million " + NumberToText(number % 1000000);
		}
		if (number >= 2000000 && number <= 999999999)
		{
			return NumberToText(number / 1000000) + " Millions " + NumberToText(number % 1000000);
		}
		if (number >= 1000000000 && number <= 1999999999)
		{
			return "One Billion " + NumberToText(number % 1000000000);
		}
		else
		{
			return NumberToText(number / 1000000000) + " Billions " + NumberToText(number % 1000000000);
		}
	}

	short ReadYear()
	{
		short year = 0;
		do
		{
			cout << "Please enter a year? ";
			cin >> year;

		} while (year < 0);

		return year;
	}

	bool IsLeapYear(short year)
	{
		return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
	}

	int NumberOfDaysInYear(short year)
	{
		return IsLeapYear(year) ? 366 : 365;
	}

	int NumberOfHoursInYear(short year)
	{
		return NumberOfDaysInYear(year) * 24;
	}

	int NumberOfMinutesInYear(short year)
	{
		return NumberOfHoursInYear(year) * 60;
	}

	int NumberOfSecondsInYear(short year)
	{
		return NumberOfMinutesInYear(year) * 60;
	}

	short ReadMonth()
	{
		short month = 0;
		do
		{
			cout << "Please enter a Month? ";
			cin >> month;
		} while (month < 1 || month >12);
		return month;
	}

	short NumberOfDaysInMonth(short year, short month)
	{
		int arr[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
		return (month == 2) ? (IsLeapYear(year) ? 29 : 28) : arr[month - 1];
	}

	int NumberOfHoursInMOnth(short year, short month)
	{
		return NumberOfDaysInMonth(year, month) * 24;
	}

	int NumberOfMinutesIMonth(short year, short month)
	{
		return NumberOfHoursInMOnth(year, month) * 60;
	}

	int NumberOfSecondsInMonth(short year, short month)
	{
		return NumberOfMinutesIMonth(year, month) * 60;
	}

	short ReadDay()
	{
		short day = 0;
		cout << "Please enter a day? ";
		cin >> day;

		return day;
	}

	short DayOfWeekOrder(short year, short month, short day)
	{
		short a = (14 - month) / 12;
		short y = year - a;
		short m = month + 12 * a - 2;

		return (day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
	}

	short DayOfWeekOrder(sDate date)
	{
		return DayOfWeekOrder(date.year, date.month, date.day);
	}

	string DayShortName(short dayOfWeekOrder)
	{
		string daysArr[] = { "Sun","Mon","Tue","Wed","Thur","Fri","Sat" };
		return daysArr[dayOfWeekOrder];
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
		cout << "\t\t     Calender - " << year << "\n";
		cout << "\t\t________________________________\n\n";


		for (int i = 1; i <= 12; i++)
		{
			PrintMonthCalender(year, i);
		}


	}

	short NumberOfDaysFromBeginningOfYear(short year, short month, short day)
	{
		short totalDays = day;
		for (int i = 1; i < month; i++)
		{
			totalDays += NumberOfDaysInMonth(year, i);
		}
		return totalDays;
	}

	sDate AddDaysToDate(short Days, sDate date)
	{

		short remainingDays = Days + NumberOfDaysFromBeginningOfYear(date.year, date.month, date.day);
		short monthsDays = 0;
		date.month = 1;

		while (true)
		{
			monthsDays = NumberOfDaysInMonth(date.year, date.month);

			if (remainingDays > monthsDays)
			{
				remainingDays -= monthsDays;
				date.month++;

				if (date.month > 12)
				{
					date.year++;
					date.month = 1;
				}
			}
			else
			{
				date.day = remainingDays;
				break;
			}
		}
		return date;
	}

	sDate ReadFullDate()
	{
		sDate date;
		date.day = ReadDay();
		date.month = ReadMonth();
		date.year = ReadYear();
		return date;
	}

	bool IsDate1BeforeDate2(sDate date1, sDate date2)
	{
		return (date1.year < date2.year) ? true : ((date1.year == date2.year) ? (date1.month < date2.month ? true : (date1.month == date2.month ? date1.day < date2.day : false)) : false);
	}

	bool IsDate1EqualDate2(sDate date1, sDate date2)
	{
		return (date1.year == date2.year) ? ((date1.month == date2.month) ? (date1.day == date2.day ? true : false) : false) : false;
	}
	bool IsLastDayInMonth(sDate date)
	{
		return NumberOfDaysInMonth(date.year, date.month) == date.day;
	}
	bool IsLastMonthInYear(short month)
	{
		return month == 12;
	}

	sDate IncreaseDateByOneDay(sDate date)
	{
		if (IsLastDayInMonth(date) && IsLastMonthInYear(date.month))
		{
			date.year++;
			date.month = 1;
			date.day = 1;
		}
		else if (MyDateLib::IsLastDayInMonth(date))
		{
			date.day = 1;
			date.month++;
		}
		else
		{
			date.day++;
		}

		return date;

	}

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
			SwapDates(date1, date2);
			swapFlagValue = -1;
		}
		while (MyDateLib::IsDate1BeforeDate2(date1, date2))
		{
			days++;
			date1 = MyDateLib::IncreaseDateByOneDay(date1);
		}

		return includeEndDay ? ++days * swapFlagValue : days;
	}

	sDate GetSystemDate()
	{
		sDate Date;
		time_t t = time(0);
		tm* now = localtime(&t);

		Date.year = now->tm_year + 1900;
		Date.month = now->tm_mon + 1;
		Date.day = now->tm_wday;
		return Date;

	}

	sDate IncreaseDateByXDays(sDate date, short numOfDays = 10)
	{

		for (int i = 1; i <= numOfDays; i++)
		{
			date = IncreaseDateByOneDay(date);
		}
		return date;
	}

	sDate IncreaseDateByOneWeek(sDate date)
	{

		for (int i = 1; i <= 7; i++)
		{
			date = IncreaseDateByOneDay(date);
		}
		return date;
	}

	sDate IncreaseDateByXWeeks(sDate date, short numOfWeeks)
	{
		for (int i = 1; i <= numOfWeeks; i++)
		{
			date = IncreaseDateByOneWeek(date);
		}
		return date;
	}

	sDate IncreaseDateByOneMonth(sDate date)
	{
		if (IsLastMonthInYear(date.month))
		{
			date.month = 1;
			date.year++;
		}
		else
		{
			date.month++;
		}

		short numberOfDaysInMonth = MyDateLib::NumberOfDaysInMonth(date.year, date.month);
		if (date.day > numberOfDaysInMonth)
		{
			date.day = numberOfDaysInMonth;
		}
		
		return date;
	}

	sDate IncreaseDateByXMonths(sDate date, short numOfMonths)
	{
		for (int i = 1; i <= numOfMonths; i++)
		{
			date = IncreaseDateByOneMonth(date);
		}
		return date;
	}

	sDate IncreaseDateByOneYear(sDate date)
	{
		date.year++;
		return date;
	}

	sDate IncreaseDateByXYears(sDate date, short numOfYears)
	{
		date.year += numOfYears;
		return date;
	}

	sDate IncreaseDateByOneDecade(sDate date)
	{
		date.year += 10;
		return date;
	}

	sDate IncreaseDateByXDecade(sDate date, short numOfDecades)
	{
		date.year += numOfDecades * 10;
		return date;
	}

	sDate IncreaseDateByOneCentury(sDate date)
	{
		date.year += 100;
		return date;
	}

	sDate IncreaseDateByOneMillennim(sDate date)
	{
		date.year += 1000;
		return date;
	}

	bool IsFirstDayInMonth(short day)
	{
		return day == 1;
	}

	bool IsFirstMonthInYear(short month)
	{
		return month == 1;
	}

	sDate DecreaseDateByOneDay(sDate date)
	{
		if (IsFirstDayInMonth(date.day) && IsFirstMonthInYear(date.month))
		{
			date.year--;
			date.day = 31;
			date.month = 12;
		}
		else if (date.day == 1)
		{
			date.month--;
			date.day = MyDateLib::NumberOfDaysInMonth(date.year, date.month);
		}
		else
		{
			date.day--;
		}

		return date;
	}

	sDate DecreaseDateByXDays(sDate date, short numOfDays)
	{
		for (int i = 1; i <= numOfDays; i++)
		{
			date = DecreaseDateByOneDay(date);
		}

		return date;
	}

	sDate DecreaseDateByOneWeek(sDate date)
	{
		for (short i = 7; i >= 1; i--)
		{
			date = DecreaseDateByOneDay(date);
		}
		return date;
	}

	sDate DecreaseDateByXWeeks(sDate date, short numOfWeeks)
	{
		for (short i = numOfWeeks; i >= 1; i--)
		{
			date = DecreaseDateByOneWeek(date);
		}
		return date;
	}

	sDate DecreaseDateByOneMonth(sDate date)
	{
		if (IsFirstMonthInYear(date.month))
		{
			date.year--;
			date.month = 12;
		}
		else
		{
			date.month--;
		}

		short numberOfDaysInMonth = MyDateLib::NumberOfDaysInMonth(date.year, date.month);
		if (date.day > numberOfDaysInMonth)
		{
			date.day = numberOfDaysInMonth;
		}

		return date;
	}

	sDate DecreaseDateByXMonths(sDate date, short numOfMonths)
	{
		for (short i = numOfMonths; i >= 1; i--)
		{
			date = DecreaseDateByOneMonth(date);
		}
		return date;
	}

	sDate DecreaseDateByOneYear(sDate date)
	{
		date.year--;
		return date;
	}

	sDate DecreaseDateByXYears(sDate date, short numOfYear)
	{
		date.year -= numOfYear;
		return date;
	}

	sDate DecreaseDateByOneDecade(sDate date)
	{
		date.year -= 10;
		return date;
	}

	sDate DecreaseDateByXDecades(sDate date, short numOfDecades)
	{
		date.year -= numOfDecades * 10;
		return date;
	}

	sDate DecreaseDateByOneCentury(sDate date)
	{
		date.year -= 100;
		return date;
	}

	sDate DecreaseDateByOneMillennium(sDate date)
	{
		date.year -= 1000;

		return date;
	}

	bool IsEndOfWeek(sDate date)
	{
		return DayOfWeekOrder(date) == (short)6;
	}

	bool IsWeekEnd(sDate date)
	{
		// weekend Fri and Sat
		short dayIndex = DayOfWeekOrder(date);
		return (dayIndex == 5 || dayIndex == 6);
	}

	bool IsBusinessDay(sDate date)
	{
		return !IsWeekEnd(date);
	}

	short DaysUntilEndOfWeek(sDate date)
	{
		return 6 - DayOfWeekOrder(date);
	}

	short DaysUntilEndOfMonth(sDate date)
	{
		return NumberOfDaysInMonth(date.year, date.month) - date.day;
	}

	short DaysUntilEndOfYear(sDate date)
	{
		short numOfDaysInYear = MyDateLib::NumberOfDaysInYear(date.year);
		short numOfDaysFromBegginingOfYear = MyDateLib::NumberOfDaysFromBeginningOfYear(date.year, date.month, date.day);

		return numOfDaysInYear - numOfDaysFromBegginingOfYear;
	}

	short CalculateVacationDays(sDate dateFrom, sDate DateTo)
	{
		short DaysCount = 0;
		while (IsDate1BeforeDate2(dateFrom, DateTo))
		{
			if (IsBusinessDay(dateFrom))
				DaysCount++;

			dateFrom = IncreaseDateByOneDay(dateFrom);
		}

		return DaysCount;
	}

}

