#pragma once
#include<iostream>

using namespace std;
template <class T>

class clsDynamicArray
{
protected:
	int _Size = 0;
	T* _TempArray;
public:
	T* OriginalArray;

	clsDynamicArray(int size = 0)
	{
		if (size < 0)
			size = 0;

		_Size = size;

		OriginalArray = new T[_Size];
	}

	~clsDynamicArray()
	{
		delete[] OriginalArray;
	}

	bool SetItem(int index, T value)
	{
		if (index >= _Size || index < 0)
		{
			return false;
		}

		OriginalArray[index] = value;
		return true;
	}

	bool IsEmpty()
	{
		return _Size == 0 ? true : false;
	}

	int Size()
	{
		return _Size;
	}

	void PrintArray()
	{
		for (int i = 0; i < _Size; i++)
		{
			cout << OriginalArray[i] << "  ";
		}
		cout << "\n";
	}

	void Resize(int newSize)
	{

		if (newSize < 0)
		{
			newSize = 0;
		}

		_TempArray = new T[newSize];

		// limit the orginal size to the new size if it is less
		if (newSize < _Size)
			_Size = newSize;

		// copy all data from original array until the size 
		for (int i = 0; i < _Size; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}

		_Size = newSize;

		delete[] OriginalArray;
		OriginalArray = _TempArray;
		
	}

	T GetItem(int index)
	{
		if (index >= _Size || index < 0)
		{
			return NULL;
		}

		return OriginalArray[index];
	}

	void Reverse()
	{
		_TempArray = new T[_Size];

		for (int i = 0; i < _Size; i++)
		{
			_TempArray[i] = OriginalArray[_Size - i - 1];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}

	void Clear()
	{
		_Size = 0;
		_TempArray = new T[0];
		delete[]OriginalArray;
		OriginalArray = _TempArray;
	}
	
	bool DeleteItemAt(int index)
	{

		if (index >= _Size || index < 0)
		{
			return false;
		}

		_Size--;

		_TempArray = new T[_Size];

		
		for (int i = 0; i < index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		
		for (int i = index+1; i < _Size+1; i++)
		{
			_TempArray[i - 1] = OriginalArray[i];
		}


		delete[]OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}

	void DeleteFirstItem()
	{
		DeleteItemAt(0);
	}

	void DeleteLastItem()
	{
		DeleteItemAt(_Size - 1);
	}

	int Find(T value)
	{

		for (int i = 0; i < _Size; i++)
		{
			if (OriginalArray[i] == value)
			{
				return i;
			}
		}

		return -1;
	}

	bool DeleteItem(T value)
	{
		return DeleteItemAt(Find(value));
	}

	bool InsertAt(int index, T value)
	{

		if (index > _Size || index < 0)
		{
			return false;
		}

		_Size++;
		_TempArray = new T[_Size];
		// copy before index into temp array
		for (int i = 0; i < index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}

		_TempArray[index] = value;
		//copy the last of original array
		for (int i = index+1; i < _Size; i++)
		{
			_TempArray[i] = OriginalArray[i-1];
		}

		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}
	
	void InsertAtBeginning(T value)
	{
		InsertAt(0, value);
	}

	bool InsertBefore(int index, T value)
	{
		if (index < 1)
			return InsertAt(0, value);
		else 
			return InsertAt(index - 1, value);
	}

	bool InsertAfter(int index, T value)
	{
		if (index >= _Size)
			return InsertAt(_Size, value);
		else 
			return InsertAt(index + 1, value);
	}

	void InsertAtEnd(T value)
	{
		InsertAt(_Size,value);
	}


};

