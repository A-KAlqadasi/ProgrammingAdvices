//// Problem 31: Power of 2_3_4 ;
//
//#include<iostream>
//using namespace std;
//
//int ReadNumber(string message)
//{
//	short number = 0;
//	cout << message << endl;
//	cin >> number;
//	return number;
//}
//
//int pow(int number, int power)
//{
//	int result = 1;
//	for (int i = 1; i <= power; i++)
//	{
//		result *= number;
//	}
//	return result;
//}
//
//int main()
//{
//	int number = ReadNumber("Please enter number ? ");
//
//	int result = pow(number, 2);
//	int result2 = pow(number, 3);
//	int result3 = pow(number, 5);
//	cout << number << "^2 = " << result << endl;
//	cout << number << "^3 = " << result2 << endl;
//	cout << number << "^5 = " << result3 << endl;
//
//
//
//
//
//	system("pause>0");
//	return 0;
//}