#pragma once
#pragma warning(disable : 4996)

#include<iostream>
#include<vector>
#include<string>
#include"clsString.h"

using namespace std;


class clsDate
{
private:
	short _Day;
	short _Month;
	short _Year;


public:
	//1
	clsDate()
	{
		time_t t = time(0);
		tm* now = localtime(&t);
		_Year = now->tm_year + 1900;
		_Month = now->tm_mon + 1;
		_Day = now->tm_mday;
	}
	
	clsDate(string sDate)
	{
		vector<string >vDate = clsString::Split(sDate, "/");
		Day = stoi(vDate[0]);
		Month = stoi(vDate[1]);
		Year = stoi(vDate[2]);
	}

	clsDate(short day, short month, short year)
	{
		_Day = day;
		_Month = month;
		_Year = year;

	}

	clsDate(short dayInYear, short year)
	{
		// this will construct a date by date order in year
		clsDate Date1 = GetDateFromDayOrderInYear(dayInYear, year);
		_Day = Date1.Day;
		_Month = Date1.Month;
		_Year = Date1.Year;
	}

	void SetDay(short day)
	{
		_Day = day;
	}
	
	short GetDay()
	{
		return _Day;
	}
	
	_declspec(property(get = GetDay, put = SetDay)) short Day;

	void SetMonth(short month)
	{
		_Month = month;
	}
	
	short GetMonth()
	{
		return  _Month;
	}
	
	_declspec(property(get = GetMonth, put = SetMonth)) short Month;
	
	void SetYear(short year)
	{
		_Year = year;
	}
	
	short GetYear()
	{
		return _Year;
	}
	
	_declspec(property(get = GetYear, put = SetYear)) short Year;

	void Print()
	{
		cout << DateToString() << endl;
	}

	static clsDate GetSystemDate()
	{
		time_t t = time(0);
		tm* now = localtime(&t);
		short Day, Month, Year; 

		Year = now->tm_year + 1900;
		Month = now->tm_mon + 1;
		Day = now->tm_mday;

		return clsDate(Day, Month, Year);
	}

	static bool IsLeapYear(short year)
	{
		return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
	}

	bool IsLeapYear()
	{
		return IsLeapYear(Year);
	}

	static bool IsValidDate(clsDate date)
	{
		short numOfDaysInMonth = NumberOfDaysInMonth(date.Year, date.Month);
		if ((date.Day >= 1 && date.Day <= numOfDaysInMonth)
			&&
			(date.Month >= 1 && date.Month <= 12))
		{
			return true;
		}
		return false;
	}

	bool IsValid()
	{
		return IsValidDate(*this);
	}

	static string DateToString(clsDate date)
	{
		return  to_string(date.Day) + "/" + to_string(date.Month) + "/" + to_string(date.Year);
	}

	string DateToString()
	{
		return DateToString(*this);
	}
	
	clsDate GetDateFromDayOrderInYear(short daysOrderInYear, short year)
	{
		clsDate date;
		short remainingDays = daysOrderInYear;
		short monthDays = 0;

		date.Year = year;
		date.Month = 1;

		while (true)
		{
			monthDays = NumberOfDaysInMonth(date.Year, date.Month);

			if (remainingDays > monthDays)
			{
				remainingDays -= monthDays;
				date.Month++;
			}
			else
			{
				date.Day = remainingDays;
				break;
			}
		}
		return date;
	}

	static int NumberOfDaysInYear(short year)
	{
		return IsLeapYear(year) ? 366 : 365;
	}

	int NumberOfDaysInYear()
	{
		return NumberOfDaysInYear(Year);
	}

	static int NumberOfHoursInYear(short year)
	{
		return NumberOfDaysInYear(year) * 24;
	}

	int NumberOfHoursInYear()
	{
		NumberOfHoursInYear(Year);
	}

	static int NumberOfMinutesInYear(short year)
	{
		return NumberOfHoursInYear(year) * 60;
	}

	int NumberOfMinutesInYear()
	{
		return NumberOfMinutesInYear(Year);
	}

	static int NumberOfSecondsInYear(short year)
	{
		return NumberOfMinutesInYear(year) * 60;
	}

	int NumberOfSecondsInYear()
	{
		return NumberOfSecondsInYear(Year);
	}

	static short NumberOfDaysInMonth(short year, short month)
	{
		int arr[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
		return (month == 2) ? (IsLeapYear(year) ? 29 : 28) : arr[month - 1];
	}

	short NumberOfDaysInMonth()
	{
		return NumberOfDaysInMonth(Year, Month);
	}

	static int NumberOfHoursInMOnth(short year, short month)
	{
		return NumberOfDaysInMonth(year, month) * 24;
	}

	int NumberOfHoursInMOnth()
	{
		return NumberOfHoursInMOnth(Year, Month);
	}

	static int NumberOfMinutesIMonth(short year, short month)
	{
		return NumberOfHoursInMOnth(year, month) * 60;
	}

	int NumberOfMinutesIMonth()
	{
		return NumberOfMinutesIMonth(Year, Month);
	}

	static int NumberOfSecondsInMonth(short year, short month)
	{
		return NumberOfMinutesIMonth(year, month) * 60;
	}

	int NumberOfSecondsInMonth()
	{
		return NumberOfSecondsInMonth(Year, Month);
	}

	static short DayOfWeekOrder(short year, short month, short day)
	{
		short a = (14 - month) / 12;
		short y = year - a;
		short m = month + 12 * a - 2;

		return (day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
	}
	static short DayOfWeekOrder(clsDate date)
	{
		return DayOfWeekOrder(date.Year, date.Month, date.Day);
	}

	short DayOfWeekOrder()
	{
		return  DayOfWeekOrder(*this);
	}

	// --
	static string DayShortName(short year, short month, short day)
	{
		short dayOfWeekOrder = DayOfWeekOrder(year, month, day);

		return DayShortName(dayOfWeekOrder);
	}
	
	static string DayShortName(short dayOfWeekOrder)
	{
		string daysArr[] = { "Sun","Mon","Tue","Wed","Thur","Fri","Sat" };
		return daysArr[dayOfWeekOrder];
	}
	
	string DayShortName()
	{
		return DayShortName(Year, Month, Day);
	}

	static string MonthShortName(int monthNumber)
	{
		string monthArr[12] = { "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" };
		return monthArr[monthNumber - 1];
	}
	
	string MonthShortName()
	{
		return MonthShortName(Month);
	}
	//--

	static void PrintMonthCalender(short year, short month)
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

	void PrintMonthCalender()
	{
		PrintMonthCalender(Year, Month);
	}

	static void PrintYearCalender(short year)
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

	void PrintYearCalender()
	{
		PrintYearCalender(Year);
	}

	static short DaysFromTheBeginningOfYear(short year, short month, short day)
	{
		short totalDays = day;
		for (int i = 1; i < month; i++)
		{
			totalDays += NumberOfDaysInMonth(year, i);
		}
		return totalDays;
	}

	static short DaysFromTheBeginningOfYear(clsDate date)
	{
		return DaysFromTheBeginningOfYear(date.Year, date.Month, date.Day);
	}

	short DaysFromTheBeginningOfYear()
	{
		return DaysFromTheBeginningOfYear(*this);
	}

	static clsDate AddDays(short Days, clsDate date)
	{

		short remainingDays = Days + DaysFromTheBeginningOfYear(date.Year, date.Month, date.Day);
		short monthsDays = 0;
		date.Month = 1;

		while (true)
		{
			monthsDays = NumberOfDaysInMonth(date.Year, date.Month);

			if (remainingDays > monthsDays)
			{
				remainingDays -= monthsDays;
				date.Month++;

				if (date.Month > 12)
				{
					date.Year++;
					date.Month = 1;
				}
			}
			else
			{
				date.Day = remainingDays;
				break;
			}
		}
		return date;
	}

	clsDate AddDays(short Days)
	{
		return AddDays(Days, *this);
	}

	static bool IsDate1EqualDate2(clsDate date1, clsDate date2)
	{
		return (date1.Year == date2.Year) ? ((date1.Month == date2.Month) ? (date1.Day == date2.Day ? true : false) : false) : false;
	}
	
	bool IsDateEqualDate2(clsDate date2)
	{
		return IsDate1EqualDate2(*this, date2);
	}
	
	static bool IsDate1BeforeDate2(clsDate date1, clsDate date2)
	{
		return (date1.Year < date2.Year) ? true : ((date1.Year == date2.Year)
			? (date1.Month < date2.Month ? true : (date1.Month == date2.Month ? date1.Day < date2.Day : false)) : false);
	}

	bool IsDateBeforeDate2(clsDate date2)
	{
		return IsDate1BeforeDate2(*this, date2);
	}

	static bool IsDate1AfterDate2(clsDate date1, clsDate date2)
	{
		return !(IsDate1BeforeDate2(date1, date2) || IsDate1EqualDate2(date1, date2));
	}

	bool IsDateAfterDate2(clsDate date2)
	{
		return IsDate1AfterDate2(*this, date2);
	}

	static bool IsLastDayInMonth(clsDate date)
	{
		return NumberOfDaysInMonth(date.Year, date.Month) == date.Day;
	}

	bool IsLastDayInMonth()
	{
		return IsLastDayInMonth(*this);
	}

	static bool IsLastMonthInYear(short month)
	{
		return month == 12;
	}

	bool IsLastMonthInYear()
	{
		return IsLastMonthInYear(Month);
	}

	static clsDate AddOneDay(clsDate& date)
	{
		if (IsLastDayInMonth(date) && IsLastMonthInYear(date.Month))
		{
			date.Year++;
			date.Month = 1;
			date.Day = 1;
		}
		else if (IsLastDayInMonth(date))
		{
			date.Day = 1;
			date.Month++;
		}
		else
		{
			date.Day++;
		}

		return date;

	}

	void AddOneDay()
	{
		*this = AddOneDay(*this);
	}

	//--
	static void SwapDates(clsDate& date1, clsDate& date2)
	{
		clsDate Temp;
		Temp.Year = date1.Year;
		Temp.Month = date1.Month;
		Temp.Day = date1.Day;

		date1.Year = date2.Year;
		date1.Month = date2.Month;
		date1.Day = date2.Day;

		date2.Year = Temp.Year;
		date2.Month = Temp.Month;
		date2.Day = Temp.Day;
	}

	static int GetDifferenceInDays(clsDate date1, clsDate date2, bool includeEndDay = false)
	{
		short days = 0;
		short swapFlagValue = 1;
		if (!IsDate1BeforeDate2(date1, date2))
		{
			// Swap Dates
			SwapDates(date1, date2);
			swapFlagValue = -1;
		}
		while (IsDate1BeforeDate2(date1, date2))
		{
			days++;
			date1 = AddOneDay(date1);
		}

		return includeEndDay ? ++days * swapFlagValue : days;
	}
	
	int GetDifferenceInDays(clsDate date2, bool includeEndDay = false)
	{
		return GetDifferenceInDays(*this, date2, includeEndDay);
	}

	//--
	static clsDate IncreaseDateByXDays(clsDate& date, short numOfDays)
	{

		for (int i = 1; i <= numOfDays; i++)
		{
			date = AddOneDay(date);
		}
		return date;
	}

	void IncreaseDateByXDays(short numOfDays)
	{
		 IncreaseDateByXDays(*this, numOfDays);
	}

	static clsDate IncreaseDateByOneWeek(clsDate& date)
	{

		for (int i = 1; i <= 7; i++)
		{
			date = AddOneDay(date);
		}
		return date;
	}

	void IncreaseDateByOneWeek()
	{
		 IncreaseDateByOneWeek(*this);
	}

	static clsDate IncreaseDateByXWeeks(clsDate& date, short numOfWeeks)
	{
		for (int i = 1; i <= numOfWeeks; i++)
		{
			date = IncreaseDateByOneWeek(date);
		}
		return date;
	}

	void IncreaseDateByXWeeks(short numOfWeeks)
	{
		 IncreaseDateByXWeeks(*this, numOfWeeks);
	}

	static clsDate IncreaseDateByOneMonth(clsDate& date)
	{
		if (IsLastMonthInYear(date.Month))
		{
			date.Month = 1;
			date.Year++;
		}
		else
		{
			date.Month++;
		}

		short numberOfDaysInMonth = NumberOfDaysInMonth(date.Year, date.Month);
		if (date.Day > numberOfDaysInMonth)
		{
			date.Day = numberOfDaysInMonth;
		}

		return date;
	}

	void IncreaseDateByOneMonth()
	{
		 IncreaseDateByOneMonth(*this);
	}

	static clsDate IncreaseDateByXMonths(clsDate& date, short numOfMonths)
	{
		for (int i = 1; i <= numOfMonths; i++)
		{
			date = IncreaseDateByOneMonth(date);
		}
		return date;
	}

	void IncreaseDateByXMonths(short numOfMonths)
	{
		 IncreaseDateByXMonths(*this, numOfMonths);
	}

	static clsDate IncreaseDateByOneYear(clsDate& date)
	{
		date.Year++;
		return date;
	}

	void IncreaseDateByOneYear()
	{
		 IncreaseDateByOneYear(*this);
	}

	static clsDate IncreaseDateByXYears(clsDate& date, short numOfYears)
	{
		date.Year += numOfYears;
		return date;
	}

	void IncreaseDateByXYears(short numOfYears)
	{
		 IncreaseDateByXYears(*this, numOfYears);
	}

	static clsDate IncreaseDateByOneDecade(clsDate& date)
	{
		date.Year += 10;
		return date;
	}

	void IncreaseDateByOneDecade()
	{
		 IncreaseDateByOneDecade(*this);
	}

	static clsDate IncreaseDateByXDecade(clsDate& date, short numOfDecades)
	{
		date.Year += numOfDecades * 10;
		return date;
	}

	void IncreaseDateByXDecade(short numOfDecades)
	{
		 IncreaseDateByXDecade(*this, numOfDecades);
	}

	static clsDate IncreaseDateByOneCentury(clsDate& date)
	{
		date.Year += 100;
		return date;
	}

	void IncreaseDateByOneCentury()
	{
		 IncreaseDateByOneCentury(*this);
	}

	static clsDate IncreaseDateByOneMillennium(clsDate& date)
	{
		date.Year += 1000;
		return date;
	}

	void IncreaseDateByOneMillennium()
	{
		 IncreaseDateByOneMillennium(*this);
	}

	static bool IsFirstDayInMonth(short day)
	{
		return day == 1;
	}

	static bool IsFirstMonthInYear(short month)
	{
		return month == 1;
	}

	static clsDate DecreaseDateByOneDay(clsDate& date)
	{
		if (IsFirstDayInMonth(date.Day) && IsFirstMonthInYear(date.Month))
		{
			date.Year--;
			date.Day = 31;
			date.Month = 12;
		}
		else if (date.Day == 1)
		{
			date.Month--;
			date.Day = NumberOfDaysInMonth(date.Year, date.Month);
		}
		else
		{
			date.Day--;
		}

		return date;
	}

	void DecreaseDateByOneDay()
	{
		 DecreaseDateByOneDay(*this);
	}

	static clsDate DecreaseDateByXDays(clsDate& date, short numOfDays)
	{
		for (int i = 1; i <= numOfDays; i++)
		{
			date = DecreaseDateByOneDay(date);
		}

		return date;
	}

	void DecreaseDateByXDays(short numOfDays)
	{
		 DecreaseDateByXDays(*this, numOfDays);
	}

	static clsDate DecreaseDateByOneWeek(clsDate& date)
	{
		for (short i = 7; i >= 1; i--)
		{
			date = DecreaseDateByOneDay(date);
		}
		return date;
	}

	void DecreaseDateByOneWeek()
	{
		 DecreaseDateByOneWeek(*this);
	}

	static clsDate DecreaseDateByXWeeks(clsDate& date, short numOfWeeks)
	{
		for (short i = numOfWeeks; i >= 1; i--)
		{
			date = DecreaseDateByOneWeek(date);
		}
		return date;
	}

	void DecreaseDateByXWeeks(short numOfWeeks)
	{
		 DecreaseDateByXWeeks(*this, numOfWeeks);
	}

	static clsDate DecreaseDateByOneMonth(clsDate& date)
	{
		if (IsFirstMonthInYear(date.Month))
		{
			date.Year--;
			date.Month = 12;
		}
		else
		{
			date.Month--;
		}

		short numberOfDaysInMonth = NumberOfDaysInMonth(date.Year, date.Month);
		if (date.Day > numberOfDaysInMonth)
		{
			date.Day = numberOfDaysInMonth;
		}

		return date;
	}

	void DecreaseDateByOneMonth()
	{
		 DecreaseDateByOneMonth(*this);
	}

	static clsDate DecreaseDateByXMonths(clsDate& date, short numOfMonths)
	{
		for (short i = numOfMonths; i >= 1; i--)
		{
			date = DecreaseDateByOneMonth(date);
		}
		return date;
	}

	void DecreaseDateByXMonths(short numOfMonths)
	{
		 DecreaseDateByXMonths(*this, numOfMonths);
	}

	static clsDate DecreaseDateByOneYear(clsDate& date)
	{
		date.Year--;
		return date;
	}

	void DecreaseDateByOneYear()
	{
		 DecreaseDateByOneYear(*this);
	}

	static clsDate DecreaseDateByXYears(clsDate& date, short numOfYear)
	{
		date.Year -= numOfYear;
		return date;
	}

	void DecreaseDateByXYears(short numOfYear)
	{
		 DecreaseDateByXYears(*this, numOfYear);
	}

	static clsDate DecreaseDateByOneDecade(clsDate& date)
	{
		date.Year -= 10;
		return date;
	}

	void DecreaseDateByOneDecade()
	{
		 DecreaseDateByOneDecade(*this);
	}

	static clsDate DecreaseDateByXDecades(clsDate& date, short numOfDecades)
	{
		date.Year -= numOfDecades * 10;
		return date;
	}

	void DecreaseDateByXDecades(short numOfDecades)
	{
		 DecreaseDateByXDecades(*this, numOfDecades);
	}

	static clsDate DecreaseDateByOneCentury(clsDate& date1)
	{
		date1.Year -= 100;
		return date1;
	}

	void DecreaseDateByOneCentury()
	{
		 DecreaseDateByOneCentury(*this);
	}

	static clsDate DecreaseDateByOneMillennium(clsDate& date)
	{
		date.Year -= 1000;
		return date;
	}

	void DecreaseDateByOneMillennium()
	{
		 DecreaseDateByOneMillennium(*this);
	}

	static bool IsEndOfWeek(clsDate date)
	{
		return DayOfWeekOrder(date) == (short)6;
	}

	bool IsEndOfWeek()
	{
		return IsEndOfWeek(*this);
	}

	static bool IsWeekEnd(clsDate date)
	{
		// weekend Fri and Sat
		short dayIndex = DayOfWeekOrder(date);
		return (dayIndex == 5 || dayIndex == 6);
	}

	bool IsWeekEnd()
	{
		return IsWeekEnd(*this);
	}

	static bool IsBusinessDay(clsDate date)
	{
		return !IsWeekEnd(date);
	}

	bool IsBusinessDay()
	{
		return IsBusinessDay(*this);
	}

	static short DaysUntilEndOfWeek(clsDate date)
	{
		return 6 - DayOfWeekOrder(date);
	}

	short DaysUntilEndOfWeek()
	{
		return DaysUntilEndOfWeek(*this);
	}

	static short DaysUntilEndOfMonth(clsDate date)
	{
		return NumberOfDaysInMonth(date.Year, date.Month) - date.Day;
	}

	short DaysUntilEndOfMonth()
	{
		return DaysUntilEndOfMonth(*this);
	}

	static short DaysUntilEndOfYear(clsDate date)
	{
		short numOfDaysInYear = NumberOfDaysInYear(date.Year);
		short numOfDaysFromBegginingOfYear = DaysFromTheBeginningOfYear(date.Year, date.Month, date.Day);

		return numOfDaysInYear - numOfDaysFromBegginingOfYear;
	}

	short DaysUntilEndOfYear()
	{
		return DaysUntilEndOfYear(*this);
	}

	static short CalculateBusinessDays(clsDate dateFrom, clsDate DateTo)
	{
		short DaysCount = 0;
		while (IsDate1BeforeDate2(dateFrom, DateTo))
		{
			if (IsBusinessDay(dateFrom))
				DaysCount++;

			dateFrom = AddOneDay(dateFrom);
		}

		return DaysCount;
	}

	static short CalculateVacationDays(clsDate dateFrom, clsDate DateTo)
	{
		return CalculateBusinessDays(dateFrom, DateTo);
	}

	static clsDate CalculateVacationReturnDate(clsDate dateFrom, short vacationDays)
	{
		short WeekEndCounter = 0;

		// if the first date is weekend increase until the first business date
		while (IsWeekEnd(dateFrom))
		{
			dateFrom = AddOneDay(dateFrom);
		}

		for (short i = 1; i <= vacationDays + WeekEndCounter; i++)
		{
			// here we add the vacation dates to add all weekends 
			if (IsWeekEnd(dateFrom))
			{
				WeekEndCounter++;
			}

			dateFrom = AddOneDay(dateFrom);
		}

		//in case the return date is weekend keep adding one day until you reach business day
		while (IsWeekEnd(dateFrom))
		{
			dateFrom = AddOneDay(dateFrom);
		}
		return dateFrom;
	}

	//--
	enum enDateCompare { Before = -1, Equal = 0, After = 1 };

	static enDateCompare CompareDates(clsDate date1, clsDate date2)
	{
		if (IsDate1BeforeDate2(date1, date2))
			return enDateCompare::Before;
		if (IsDate1EqualDate2(date1, date2))
			return enDateCompare::Equal;

		return enDateCompare::After;
	}

	enDateCompare CompareDates( clsDate date2)
	{
		return CompareDates(*this, date2);
	}
	//--

	static string DateFormat(clsDate date, string format = "dd/mm/yyyy")
	{
		string newDateFormat = "";
		newDateFormat = clsString::ReplaceWord(format, "dd", to_string(date.Day));
		newDateFormat = clsString::ReplaceWord(newDateFormat, "mm", to_string(date.Month));
		newDateFormat = clsString::ReplaceWord(newDateFormat, "yyyy", to_string(date.Year));

		return newDateFormat;
	}
	
	string DateFormat(string format = "dd/mm/yyyy")
	{
		return DateFormat(*this, format);
	}

};



