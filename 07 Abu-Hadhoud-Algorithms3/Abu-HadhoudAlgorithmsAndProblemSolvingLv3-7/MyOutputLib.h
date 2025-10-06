#pragma once

#include <iostream>
using namespace std;

namespace MyOutputLib
{
	void PrintDigitsInReserved(int Number) {
		int Num = 0;
		do {

			Num = Number % 10;
			cout << Num << endl;

			Number = Number / 10;

		} while (Number > 0);

	}

	void PrintArray(int Array[100], int arrLength) {
		for (int i = 0; i < arrLength; i++)
			cout << Array[i] << " ";
		    cout << endl;
	}

	int MinNumberOfArray(int Array[100], int arrLength)
	{
		int min = Array[0];
		for (int i = 0; i < arrLength; i++) {

			if (Array[i] <= min)
				min = Array[i];
		}
		return min;
	}

	int MaxNumberOfArray(int Array[100], int arrLength)
	{
		int max = Array[0];
		for (int i = 0; i < arrLength; i++) {
			if (Array[i] >= max)
				max = Array[i];
		}
		return max;
	}

	int OddCountInArray(int Array[100], int arrLength) {
		int counter = 0;
		for (int i = 0; i < arrLength; i++)
		{
			if (Array[i] % 2 != 0)
				counter++;
		}
		return counter;
	}
	int EvenCountInArray(int Array[100], int arrLength) {
		int counter = 0;
		for (int i = 0; i < arrLength; i++)
		{
			if (Array[i] % 2 == 0)
				counter++;
		}
		return counter;
	}
	int PositiveCountInArray(int Array[100], int arrLength) {
		int counter = 0;
		for (int i = 0; i < arrLength; i++)
		{
			if (Array[i] >= 0)
				counter++;
		}
		return counter;
	}
	int NegitiveCountInArray(int Array[100], int arrLength) {
		int counter = 0;
		for (int i = 0; i < arrLength; i++)
		{
			if (Array[i] < 0)
				counter++;
		}
		return counter;
	}

	void Swap(int& A, int& B) {
		int Temp;
		Temp = A;
		A = B;
		B = Temp;
	}

	void PrintRangeNumbersFrom1ToN(int N)
	{
		cout << "Range Numbers from 1 to "<< N << ":\n";
		for (int counter = N; counter >= 1; counter--)
		{
			cout << counter << endl;
		}
	}

}