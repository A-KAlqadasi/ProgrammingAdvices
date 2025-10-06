#include<iostream>
#include <stack>
#include <queue>
using namespace std;

int main()
{

	// create a stack of ints
	queue<int> MyQueue;
	queue<int> MyQueue2;
	MyQueue.push(10);
	MyQueue.push(20);
	MyQueue.push(30);
	MyQueue.push(40);
	
	MyQueue2.push(50);
	MyQueue2.push(60);
	MyQueue2.push(70);
	MyQueue2.push(80);

	/*
	cout << "\nCount: " << MyQueue.size();
	cout << "\nFront: " << MyQueue.front();
	cout << "\nBack : " << MyQueue.back();*/

	MyQueue.swap(MyQueue2);

	cout << "\nqueue1 : ";
	while (!MyQueue.empty())
	{
		cout << MyQueue.front() <<"  ";
		 
		//pop the top
		MyQueue.pop();
	}
	
	cout << "\nqueue2 : ";
	while (!MyQueue2.empty())
	{
		cout << MyQueue2.front() << "  ";

		//pop the top
		MyQueue2.pop();
	}
}