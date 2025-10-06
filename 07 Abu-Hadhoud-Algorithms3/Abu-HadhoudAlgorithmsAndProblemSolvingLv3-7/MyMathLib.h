#pragma once

#include <iostream>
using namespace std;

namespace MyMathLib
{
	int SumArray(int Array[100], int arrLength) {
		int Sum = 0;
		for (int i = 0; i < arrLength; i++) {
			Sum += Array[i];
		}
		return Sum;
	}

	float ArrayAverage(int Array[100], int arrLength) {
		return (float)SumArray(Array, arrLength) / arrLength;
	}

	int Sum2Numbers(int Number1, int Number2)
	{
		return Number1 + Number2;
	}
	

	enum enPrimeNotPrime { Prime = 1, NotPrime = 2 };
	enPrimeNotPrime CheckPrime(int Number) {
		int M = round(Number / 2);

		for (int i = 2; i <= M; i++) {
			if (Number % i == 0)
				return NotPrime;
		}
		return Prime;
	}

	// 
	bool IsPerfectNumber(int Number) {
		int HalfOfNumber = Number / 2;
		int Sum = 0;
		for (int i = 1; i <= HalfOfNumber; i++) {
			if (Number % i == 0) {
				Sum += i;
			}
		}
		return Sum == Number;
	}

	// 1234 - 1+2+3+4 
	int SumOfDigits(int Number) { 
		int Num = 0;
		int Sum = 0;
		while (Number > 0) {

			Num = Number % 10;
			Number = Number / 10;
			Sum += Num;

		}
		return Sum;
	}

	int ReverseNumber(int Number) {
		int Remander = 0;
		int Number2 = 0;
		while (Number > 0) {
			Remander = Number % 10;
			Number = Number / 10;
			Number2 = Number2 * 10 + Remander;
		}
		return Number2;
	}

	int CountDigitFrequency(int Number, short Digit) {
		int Remander = 0;
		int Frequence = 0;
		while (Number > 0) {
			Remander = Number % 10;
			Number = Number / 10;
			if (Remander == Digit)
				Frequence++;
		}
		return Frequence;
	}

	// the palindom number is like 12321 we can read it from any side.
	bool IsPalindomNumber(int Number) {
		return Number == ReverseNumber(Number);
	}

	// Areas
	float RectangelArea()
	{
		float width =0, length =0;
		cout << "Enter Rectangle width? ";
		cin >> width;
		cout << "Enter Rectangle length? ";
		cin >> length;
		return width * length;
	}
	float TrianglrArea()
	{
		float base, high;
		
		cout << "Enter the base of the traingle :: ";
		cin >> base;
		cout << "Enter the high :: ";
		cin >> high;
		return  base / 2 * high;
	}
	float CircleArea()
	{
		short radius;
		const double PI = 3.14;
		cout << "Enter the radius of the circle :: ";
		cin >> radius;
		return  radius * radius * PI;
	}

	enum enOddOrEven { Odd = 1, Even = 2 };
	enOddOrEven CheckEvenOrOdd(int Num) {
		int Result = Num % 2;
		if (Result == 0)
			return enOddOrEven::Even;
		else
			return enOddOrEven::Odd;
	}
	float CalculateHalfNumber(int Num) {
		return (float)Num / 2;
	}

	int SumOddNumbersFrom1ToN(int Number)
	{
		int sum = 0;
		for (int i = 0; i <= Number; i++)
		{

			if (CheckEvenOrOdd(i) == enOddOrEven::Odd) {
				sum += i;
			}
		}
		return sum;
	}
	int SumEvenNumbersFrom1ToN(int Number)
	{
		int sum = 0;
		for (int i = 0; i <= Number; i++)
		{

			if (CheckEvenOrOdd(i) == enOddOrEven::Even) {
				sum += i;
			}
		}
		return sum;
	}
	int Factorial(int Number)
	{
		int F = 1;
		for (int counter = 1; counter <= Number; counter++) {
			F = F * counter;
		}
		return F;
	}

	enum enOperationType {	Add = '+', subtract = '-', Multiply = '*', Divide = '/'};
	enOperationType ReadMathOperationType()
	{
		char OT = '+';
		cout << "Choose the operation type(+ , - , * ,/)?" << endl;
		cin >> OT;
		return (enOperationType)OT;
	}
	float Calculator(float Number1, float Number2, enOperationType OpType)
	{
		switch (OpType)
		{
		case enOperationType::Add:
			return Number1 + Number2;
		case enOperationType::subtract:
			return Number1 - Number2;
		case enOperationType::Multiply:
			return Number1 * Number2;
		case enOperationType::Divide:
			return Number1 / Number2;
		default:
			return Number1 + Number2;

		}
	}

	float CalculateRemander(float TotalBill, float TotalCashPaid)
	{
		return TotalCashPaid - TotalBill;
	}

	float HoursToDays(float NumberOfHours)
	{
		return (float)NumberOfHours / 24;
	}
	float DaysToHours(float NumberOfDays)
	{
		return (float)NumberOfDays * 24;
	}
	float DaysToWeeks(float NumberOfDays)
	{
		return (float)NumberOfDays / 7;
	}
	float WeeksToDays(float NumberOfWeeks)
	{
		return (float)NumberOfWeeks * 7;
	}
	float HoursToWeeks(float NumberOfHours)
	{
		return (float)NumberOfHours / 24 / 7;
	}
	float WeeksToHours(float NumberOfWeeks)
	{
		return (float)NumberOfWeeks * 24 * 7;
	}

}
