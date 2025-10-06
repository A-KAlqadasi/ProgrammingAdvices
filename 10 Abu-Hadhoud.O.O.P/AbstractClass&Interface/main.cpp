#include<iostream>
using namespace std;

// abstract class / interface / contract 
class clsMobile
{
	// pure virtual function
	virtual void Dial(string phoneNumber) = 0;
	virtual void SendSMS(string phoneNumber, string textMessage) = 0;
	virtual void TakePicture() = 0;

};

class clsIphone :public clsMobile
{
public:
	void Dial(string phoneNumber)
	{

	};

	void SendSMS(string phoneNumber, string textMessage)
	{

	};
	void TakePicture()
	{

	};

};

class clsSamsung :clsMobile
{
	void Dial(string phoneNumber)
	{

	};

	void SendSMS(string phoneNumber, string textMessage)
	{

	};
	void TakePicture()
	{

	};
};


int main()
{
	clsIphone M1;
	M1.Dial("2345");

	clsSamsung S1;
	

	system("pause>0");
	return 0;
}