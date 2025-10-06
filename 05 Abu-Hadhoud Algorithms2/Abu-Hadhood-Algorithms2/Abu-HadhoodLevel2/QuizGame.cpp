//#include <iostream>
//#include <cstdlib>
//using namespace std;
//
//enum enQuestionLevel {Easy = 1 , Middle = 2, Hard = 3 ,Mix = 4};
//enum enOperationType {Add = 1 , Sub = 2 , Mul = 3 , Div = 4 , Mixop = 5};
//
//struct stQuestion
//{
//	int Number1 = 0;
//	int Number2 = 0;
//	enQuestionLevel QuestionLevel;
//	enOperationType OperationType;
//	int CorrectAnswer = 0;
//	int PlayerAnswer  = 0;
//	bool AnswerResult = false;
//};
//
//struct stQuizz 
//{
//	stQuestion QuestionList[100];
//	short NumberOfQuestions;
//	enQuestionLevel QuestionLevel;
//	enOperationType OpType;
//	short NumberOfWrongAnswers = 0;
//	short NumberOfRightAnswers = 0;
//	bool isPass = false;
//
//};
//int RandomNumber(int From, int To) {
//	int Number;
//	Number = rand() % (To - From + 1) + From;
//	return Number;
//
//}
//
//short ReadHowManyQuestions() {
//	short QuizNumber;
//	do {
//		cout << "How Many Questions you want to answer? ";
//		cin >> QuizNumber;
//
//	} while (QuizNumber < 1|| QuizNumber >10);
//
//	return QuizNumber;
//}
//enQuestionLevel ReadQuistionLevel() {
//	short Level = 0;
//	do {
//		cout << "Enter Question Level [1]Easy, [2]Mid, [3]Hard, [4]Mix ? ";
//		cin >> Level;
//	} while (Level < 1 || Level>4);
//	return (enQuestionLevel)Level;
//}
//enOperationType ReadOpType() {
//	short type = 0;
//	do {
//		cout << "Enter Operation Type [1]Add, [2]Sub, [3]Mul, [4]Div, [5]Mix ? ";
//		cin >> type;
//	} while (type < 1 || type>5);
//	return (enOperationType)type;
//
//}
//int SimpleCalculator(int Number1, int Number2, enOperationType OpType)
//{
//	switch (OpType)
//	{
//	case Add:
//		return Number1 + Number2;
//	case Sub:
//		return Number1 - Number2;
//	case Mul:
//		return Number1 * Number2;
//	case Div:
//		return Number1 / Number2;
//	default:
//		return Number1 + Number2;
//	}
//}
//void SetScreenColor(bool result)
//{
//	if (result)
//		system("color 2F");
//	else
//	{
//		cout << "\a";
//		system("color 4F");
//	}
//}
//stQuestion GenerateQuestion(enQuestionLevel QuestionLevel, enOperationType OpType)
//{
//	stQuestion Question;
//	if (QuestionLevel == enQuestionLevel::Mix)
//	{
//		QuestionLevel = (enQuestionLevel)RandomNumber(1, 3);
//	}
//	if (OpType == enOperationType::Mixop)
//	{
//		OpType = (enOperationType)RandomNumber(1, 4);
//	}
//	Question.OperationType = OpType;
//	Question.QuestionLevel = QuestionLevel;
//
//	switch (QuestionLevel)
//	{
//	case enQuestionLevel::Easy:
//		Question.Number1 = RandomNumber(1, 10);
//		Question.Number2 = RandomNumber(1, 10);
//		Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
//		return Question;
//		
//	case enQuestionLevel::Middle:
//		Question.Number1 = RandomNumber(10, 50);
//		Question.Number2 = RandomNumber(10, 50);
//		Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
//		return Question;
//
//	case enQuestionLevel::Hard:
//		Question.Number1 = RandomNumber(50, 100);
//		Question.Number2 = RandomNumber(50, 100);
//		Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
//		return Question;
//
//	}
//
//}
//void GenerateQuizzQuestions(stQuizz& Quizz)
//{
//	for (short Question = 0; Question < Quizz.NumberOfQuestions; Question++)
//	{
//		Quizz.QuestionList[Question] = GenerateQuestion(Quizz.QuestionLevel, Quizz.OpType);
//	}
//}
//string GetOpTypeSymbol(enOperationType OpType)
//{
//	string OpTypeArray[4] = { "+", "-", "*","/" };
//	return OpTypeArray[OpType - 1];
//}
//void PrintTheQuestion(stQuizz& Quizz, short QuestionNumber)
//{
//	cout << "\n";
//	cout << "Question [" << QuestionNumber + 1 << "/" << Quizz.NumberOfQuestions << "]\n\n";
//	cout << Quizz.QuestionList[QuestionNumber].Number1 << endl;
//	cout << Quizz.QuestionList[QuestionNumber].Number2 << " ";
//	cout << GetOpTypeSymbol(Quizz.QuestionList[QuestionNumber].OperationType) << endl;
//	cout << "-------\n";
//
//}
//int ReadQuestionAnswer()
//{
//	int Answer = 0;
//	cin >> Answer;
//	return Answer;
//}
//void CorrectTheQuestionAnswer(stQuizz& Quizz, short QuestionNumber)
//{
//	if (Quizz.QuestionList[QuestionNumber].PlayerAnswer != Quizz.QuestionList[QuestionNumber].CorrectAnswer)
//	{
//		Quizz.QuestionList[QuestionNumber].AnswerResult = false;
//		Quizz.NumberOfWrongAnswers++;
//		cout << "Wrong Answer :-(\n";
//		cout << "The right answer is: ";
//		cout << Quizz.QuestionList[QuestionNumber].CorrectAnswer << endl;
//	}
//	else
//	{
//		Quizz.QuestionList[QuestionNumber].AnswerResult = true;
//		Quizz.NumberOfRightAnswers++;
//		cout << "Right Answer :-)\n";
//	}
//	SetScreenColor(Quizz.QuestionList[QuestionNumber].AnswerResult);
//
//}
//void AskAndCorrectQuestioListAnswers(stQuizz& Quizz)
//{
//	for (short Question = 0; Question < Quizz.NumberOfQuestions; Question++)
//	{
//		PrintTheQuestion(Quizz, Question);
//		Quizz.QuestionList[Question].PlayerAnswer = ReadQuestionAnswer();
//		CorrectTheQuestionAnswer(Quizz, Question);
//	}
//	Quizz.isPass = (Quizz.NumberOfRightAnswers >= Quizz.NumberOfWrongAnswers);
//}
//
//string GetFinalResultsText(bool Pass)
//{
//	if (Pass) {
//		system("color 2F");
//		return "PASS";
//	}
//	else {
//		system("color 4F");
//		return "FAIL";
//	}
//}
//string GetQuestionLevelText(enQuestionLevel QuestionLevel)
//{
//	switch (QuestionLevel)
//	{
//	case Easy:
//		return "Easy";
//	case Middle:
//		return "Middle";
//	case Hard:
//		return "Hard";
//	case Mix:
//		return "Mix";
//	}
//}
//
//string GetOperationType(enOperationType OpType)
//{
//	string OpTypeArray[5] = { "+", "-" , "*","/","Mix" };
//	return OpTypeArray[OpType - 1];
//}
//void PrintQuizzResults(stQuizz Quizz)
//{
//	cout << "\n";
//	cout << "--------------------------------\n\n";
//	cout << "Final Results is " << GetFinalResultsText(Quizz.isPass) << endl;
//	cout << "--------------------------------\n";
//	cout << "Number of Questions: " << Quizz.NumberOfQuestions << endl;
//	cout << "Questions Level    :" << GetQuestionLevelText(Quizz.QuestionLevel) << endl;
//	cout << "OpType             :" << GetOperationType(Quizz.OpType) << endl;
//	cout << "Number of Right Answers: " << Quizz.NumberOfRightAnswers << endl;
//	cout << "Number of Wrong Answers: " << Quizz.NumberOfWrongAnswers << endl;
//	cout << "----------------------------\n";
//
//}
//
//void PlayMathGame()
//{
//	stQuizz Quizz;
//	Quizz.NumberOfQuestions = ReadHowManyQuestions();
//	Quizz.QuestionLevel = ReadQuistionLevel();
//	Quizz.OpType = ReadOpType();
//
//	GenerateQuizzQuestions(Quizz);
//
//	AskAndCorrectQuestioListAnswers (Quizz);
//
//	PrintQuizzResults(Quizz);
//}
//
//void ResetScreen() 
//{
//	system("cls");
//	system("color 0F");
//}
//
//void StartGame()
//{
//	char PlayAgain = 'y';
//	do 
//	{
//		ResetScreen();
//		PlayMathGame();
//
//
//		cout << endl << "Do you want to play again? Y/N? ";
//		cin >> PlayAgain;
//	} while (PlayAgain == 'Y' || PlayAgain == 'y');
//}
//int main()
//{
//	srand((unsigned)time(NULL));
//
//	StartGame();
//
//	return 0;
//}