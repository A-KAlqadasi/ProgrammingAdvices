#include<iostream>
using namespace std;

class clsCalculator
{
private:
	float _Result =0;
	float _LastNumber = 0;
	string _LastOperation = "Clear";
	float _PreviousResult;

	bool _IsZero(float number)
	{
		return number == 0;
	}
public:

	void Add(float number)
	{
		_LastNumber = number;
		_LastOperation = "Adding";
		_PreviousResult = _Result;
		_Result += number;
		 
	}

	void Subtract(float number)
	{
		_LastNumber = number;
		_LastOperation = "Subtracting";
		_PreviousResult = _Result;
		_Result -= number;
	}

	void Divide(float number)
	{
		if (_IsZero(number))
			number = 1;

		_LastNumber = number;
		_LastOperation = "Dividing";
		_PreviousResult = _Result;
		_Result /= number;
		
	}

	void Multiply(float number)
	{
		_LastNumber = number;
		_LastOperation = "Multiplying";
		_PreviousResult = _Result;
		_Result *= number;
	}

	void Clear()
	{
		_LastOperation = "Clearing";
		_PreviousResult = 0;
		_Result =0;
		_LastNumber = 0;
	}

	void PrintResult()
	{
		cout << "Result ";
		cout << "After " << _LastOperation << " " << _LastNumber << " is : " << _Result << endl;
	}

	void CancelLastOperation()
	{
		_LastNumber = 0;
		_Result = _PreviousResult;
		_LastOperation = "Cancelling Last Operation ";
	}
	
};


int main()
{
	clsCalculator calculator1;

	calculator1.Clear();
	calculator1.Add(10);
	calculator1.PrintResult();

	calculator1.Add(100);
	calculator1.PrintResult();

	calculator1.Subtract(20);
	calculator1.PrintResult();


	calculator1.Multiply(10);
	calculator1.PrintResult();

	calculator1.Divide(0);
	calculator1.PrintResult();

	calculator1.Divide(2);
	calculator1.PrintResult();

	calculator1.CancelLastOperation();
	calculator1.PrintResult();

	system("pause>0");
	return 0;
}