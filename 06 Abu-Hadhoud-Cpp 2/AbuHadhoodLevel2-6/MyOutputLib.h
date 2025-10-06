#pragma once

#include <iostream>
#include <vector>
#include<iomanip>
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

	void PrintMatrix(int Matrix[3][3], short rows, short cols)
	{
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				cout << setw(3) << Matrix[i][j] << "  ";
			}
			cout << endl;
		}
	}

	int RowSum(int Matrix[3][3], short RowNumber, short Cols)
	{
		int Sum = 0;
		for (int i = 0; i < Cols; i++)
		{
			Sum += Matrix[RowNumber][i];
		}
		return Sum;
	}
	void PrintEachRowSum(int Matrix[3][3], short Rows, short Cols)
	{
		cout << "\nThe following are the sum of each row in the matrix:\n";

		for (int i = 0; i < Rows; i++)
		{
			cout << "Row " << i + 1 << " Sum = " << RowSum(Matrix, i, Cols) << endl;

		}
	}

}