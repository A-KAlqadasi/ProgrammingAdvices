#include<iostream>
using namespace std;

class Node
{
public:
	int Value;
	Node* Next;
	Node* Prev;
};

void InsertAtBeginning(Node*& head, int value)
{
	/*
		1-Create a new node with the desired value.
		2-Set the next pointer of the new node to the current head of the list.
		3-Set the previous pointer of the current head to the new node.
		4-Set the new node as the new head of the list.
	*/

	Node* newNode = new Node();
	newNode->Value = value;
	newNode->Prev = NULL;
	newNode->Next = head;

	if (head != NULL)
	{
		head->Prev = newNode;
	}

	head = newNode;

}

void PrintNodeDetails(Node* head)
{
	
	if (head->Prev != NULL)
	{
		cout << head->Prev->Value << " <--> ";
	}
	else
	{
		cout << " NULL <--> ";
	}
	cout << head->Value << " <--> ";

	if (head->Next != NULL)
	{
		cout << head->Next->Value << "\n";
	}
	else
	{
		cout << "NULL\n";
	}

}

void PrintListDetails(Node* head)
{
	cout << "\n\n";
	while (head != NULL)
	{
		PrintNodeDetails(head);
		head = head->Next;

	}
}

void PrintList(Node* head)
{
	cout << "\nNULL <--> ";
	while (head !=NULL)
	{
		cout << head->Value << " <--> ";
		head = head->Next;
	}
	cout << "NULL\n";
}

Node* Find(Node* head, int value)
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

void InsertAfter(Node* N1, int value)
{
	Node* newNode = new Node();
	newNode->Value = value;
	
	if (N1 == NULL)
	{
		cout << "\nNode to insert after is not found\n";
		return;
	}
	newNode->Next = N1->Next;
	newNode->Prev = N1;
	N1->Next = newNode;

}

void InsertAtEnd(Node*& head, int value)
{
	Node* newNode = new Node();
	newNode->Next = NULL;
	newNode->Value = value;
	if (head == NULL)
	{
		newNode->Prev = NULL;
		head = newNode;
		return;
	}

	Node* last = head;
	while (last->Next != NULL)
	{
		last = last->Next;
	}
	newNode->Prev = last;
	last->Next = newNode;

}

void DeleteNode(Node*& head, int value)
{
	Node* current = Find(head, value);
	if (current == NULL)
	{
		cout << "\nNo such node found to delete!\n";
		return;
	}

	Node* temp = current;
	if (temp->Next == NULL)
	{
		temp->Prev->Next = NULL;
		delete current;
		return;
	}
	
	if (temp == head)
	{
		head = temp->Next;
		head->Prev = NULL;
		delete current;
		return;
	}

	temp->Next->Prev = temp->Prev;
	temp->Prev->Next = temp->Next;

	delete current;
}

void DeleteFirstNode(Node*& head)
{
	if (head == NULL)
	{
		return;
	}

	Node* temp = head;
	head = head->Next;
	if (head != NULL)
	{
		head->Prev = NULL;
	}

	delete temp;
}

void DeleteLastNode(Node*& head)
{
	if (head == NULL)
	{
		return;
	}
	
	if (head->Next == NULL)
	{
		delete head;
		head = NULL;
		return;
	}


	Node* current = head;
	while (current->Next != NULL)
	{
		current = current->Next;
	}

	current->Prev->Next = NULL;

	delete current;

}

int main()
{
	
	Node* head = NULL;

	InsertAtBeginning(head, 5);
	InsertAtBeginning(head, 4);
	InsertAtBeginning(head, 3);
	InsertAtBeginning(head, 2);
	InsertAtBeginning(head, 1);

	cout << "\nLinked list content:\n";
	PrintList(head);
	PrintListDetails(head);

	

	DeleteLastNode(head);
	DeleteLastNode(head);
	DeleteLastNode(head);
	DeleteLastNode(head);
	DeleteLastNode(head);
	DeleteLastNode(head);

	cout << "\nLinked list content:\n";
	PrintList(head);
	PrintListDetails(head);
	
	system("pause>0");
	return 0;
}