#include <iostream>
using namespace std;


class Node
{
public:
	int value;
	Node* next;
};

void InsertAtBeginning(Node*& head, int value)
{
	Node *new_node = new Node();
	new_node->value = value;
	new_node->next  = head;
	head = new_node;
}

void PrintList(Node* head)
{
	cout << "\n";
	while (head != NULL)
	{
		cout << head->value << "  ";
		head = head->next;
	}
}

Node* Find(Node* head, int value)
{
	while (head != NULL)
	{
		if (head->value == value)
			return head;
		head = head->next;
	}

	return NULL;
}

void InsertAfter(Node*& prev_node, int value)
{
	if (prev_node == NULL)
	{
		cout << "\nthe given previous node cannot be NULL\n";
		return;
	}

	Node* new_node = new Node();
	new_node->value = value;
	new_node->next = prev_node->next;
	prev_node->next = new_node;

}

void InsertAtEnd(Node*& head, int value)
{
	Node* new_node = new Node();
	new_node->value = value;
	new_node->next = NULL;
	// if there is no nodes yet
	if (head == NULL)
	{
		head = new_node;
		return;
	}

	Node* lastNode = head;
	while (lastNode->next != NULL)
	{
		lastNode = lastNode->next;
	}

	lastNode->next = new_node;
	return;
}

void DeleteNode(Node*& head, int value)
{
	Node* current = head, * prev = head;

	if (head == NULL)
		return;

	if (current->value == value)
	{
		head = current->next;
		delete current;
		return;
	}

	
	while (current != NULL && current->value != value )
	{
		prev = current;
		current = current->next;
	}

	if (current == NULL) return;

	prev->next = current->next;
	delete current;

}

void DeleteFirstNode(Node*& head)
{
	Node* current = head;

	if (head == NULL)
		return;

	head = current->next;
	delete current;
	return;
}

int main()
{
	Node* head = NULL;
	InsertAtBeginning(head, 1);
	InsertAtBeginning(head, 2);
	InsertAtBeginning(head, 3);
	InsertAtBeginning(head, 4);
	InsertAtBeginning(head, 5);
	InsertAtBeginning(head, 6);


	PrintList(head);


	system("pause>0");
	return 0;
}