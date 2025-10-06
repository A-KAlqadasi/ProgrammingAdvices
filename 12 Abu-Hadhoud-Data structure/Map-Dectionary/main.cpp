#include<iostream>
#include<map>
using namespace std;




int main()
{

	map<string, int> studentsGrades;
	// reapeted key will override the previous  // dectionary
	studentsGrades["Abdulkareem"] = 95;
	studentsGrades["Waleed"] = 94;
	studentsGrades["Ali"] = 90;

	for (const auto pair : studentsGrades)
	{
		cout << "student name is : " << pair.first << " , its grades is : " << pair.second << endl;
	}

	string name = "Waleed";
	if (studentsGrades.find(name) != studentsGrades.end())
	{
		cout << "\nstudent is found\n";
	}
	else
	{
		cout << "\nstudent is not found\n";
	}

	string name2 = "Omer";
	if (studentsGrades.find(name2) != studentsGrades.end())
	{
		cout << "\nstudent is found\n";

	}
	else
	{
		cout << "\nstudent is not found\n";
	}
	system("pause>0");
	return 0;
}