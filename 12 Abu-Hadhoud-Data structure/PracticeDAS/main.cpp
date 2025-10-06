#include<iostream>
using namespace std;

class Node
{
public:
	int Value;
	Node* Next;

};

void InsertAtBeginning(Node*& head, int value)
{
	Node* newNode = new Node();
	newNode->Value = value;
	newNode->Next = head;
	head = newNode;
}

void InsertAtEnd(Node*& head, int value)
{
	Node* newNode = new Node();
	newNode->Value = value;
	newNode->Next = NULL;
	if (head == NULL)
	{
		head = newNode;
		return;
	}

	Node* lastNode = head;

	while (lastNode->Next != NULL)
	{
		lastNode = lastNode->Next;
	}
	lastNode->Next = newNode;
}

void DisplayList(Node* head)
{
	cout << "\n";
	while (head != NULL)
	{
		cout << head->Value << "  ";
		head = head->Next;
	}
}

Node *Find(Node* head, int value)
{
	while (head != NULL)
	{
		if (head->Value == value)
		{
			return head;
		}
		head = head->Next;
	}
	return NULL;
}

void InsertAfter(Node*& N1, int value)
{
	if (N1 == NULL)
	{
		cout << "\nNo found node to insert after it\n";
		return;
	}
	Node* newNode = new Node();
	newNode->Value = value;
	newNode->Next = N1->Next;
	N1->Next = newNode;
}

void DeleteNode(Node* &head, int value)
{
	
	Node* prev = head, *current = head;

	while (current != NULL)
	{
		if (current->Value == value)
		{
			prev->Next = current->Next;
			break;
		}
		prev = current;
		current = current->Next;

	}

	delete current;
}

void DeleteFirst(Node*& head)
{

	if (head == NULL)
	{
		return;
	}
	Node* temp = head;
	
	head = temp->Next;
	delete temp;

}

void DeleteLast(Node*& head)
{
	Node* current = head, * prev = head;

	if (head == NULL)
	{
		return;
	}

	if (current->Next == NULL)
	{
		head = NULL;
		delete current;
		return;
	}

	
	while (current->Next != NULL)
	{
		prev = current;
		current = current->Next;
	}
	prev->Next = NULL;
	delete current;
}

int main()
{
	
	Node* head = NULL;
	InsertAtEnd(head, 1);
	InsertAtEnd(head, 2);
	InsertAtEnd(head, 3);
	InsertAtEnd(head, 4);
	DisplayList(head);
	DeleteLast(head);
	DeleteLast(head);
	DeleteLast(head);
	DeleteLast(head);
	/*Node* N1 = Find(head, 4);
	InsertAfter(N1, 500);
	DeleteNode(head, 500);
	DeleteNode(head, 1);*/

	DisplayList(head);

	system("pause>0");
	return 0;
}