
#include <iostream>
using namespace std;

// Create a node
class Node
{
public:
    int value;
    Node* next;
    Node* prev;
};

void InsertAtBeginning(Node*& head, int value)
{
    Node* newNode = new Node();
    newNode->value = value;
    newNode->prev = NULL;
    newNode->next = head;

    if (head != NULL)
    {
        head->prev = newNode;
    }

    head = newNode;
}

void PrintList(Node* head)
{
    cout << "\nNULL <--> ";
    while (head != NULL)
    {
        cout << head->value << " <--> ";
        head = head->next;
    }
    cout << "NULL\n";
}

void PrintNodeDetails(Node* head)
{
    cout << "\n\n";

    if (head->prev != NULL)
        cout << head->prev->value << " <--> ";
    else
        cout << "NULL <--> ";

    cout << head->value << " <-- > ";

    if (head->next != NULL)
        cout << head->next->value;
    else
        cout << "NULL";

}

void PrintListDetails(Node* head)
{
    while (head != NULL)
    {
        PrintNodeDetails(head);
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

void InsertAfter(Node* current, int value)
{
    Node* new_node = new Node();
    new_node->value = value;
    new_node->prev = current;
    new_node->next = current->next;

    if (current->next != NULL)
    {
        current->next->prev = new_node;
    }

    current->next = new_node;

}

void InsertAtEnd(Node* head, int value)
{
    Node* newNode = new Node();
    newNode->value = value;
    newNode->next = NULL;
    
    if (head == NULL)
    {
        newNode->prev = NULL;
        head = newNode;
    }
    else
    {
        Node* lastNode = head;
        while (lastNode ->next != NULL)
        {
            lastNode = lastNode->next;
        }
        lastNode->next = newNode;
        newNode->prev = lastNode;
    }


}

void DeleteNode(Node*& head, Node*& nodeToDelete)
{
    if (head == NULL || nodeToDelete == NULL)
    {
        return;
    }

    if (head == nodeToDelete)
    {
        head = nodeToDelete->next;
    }

    if (nodeToDelete->next != NULL)
    {
        nodeToDelete->next->prev = nodeToDelete->prev;
    }

    if (nodeToDelete->prev != NULL)
    {
        nodeToDelete->prev->next = nodeToDelete->next;
    }

    delete nodeToDelete;
   
}

void DeleteFirstNode(Node*& head)
{
    if (head == NULL)
        return;

    Node* temp = head;
    head = head->next;
    if (head != NULL)
    {
        head->prev = NULL;
    }
    delete temp;
}

void DeleteLastNode(Node*& head)
{
    if (head == NULL)
        return;

    if (head->next == NULL)
    {
        delete head;
        head = NULL;
        return;
    }

    Node* current = head;
    // we need to find the node before last node.
    while (current->next->next != NULL)
    {
        current = current->next;
    }
    
    Node* temp = current->next;

    current->next = NULL;
    delete temp;

}


int main()
{
    Node* head = NULL;

    InsertAtEnd(head, 5);
    InsertAtEnd(head, 4);
    InsertAtEnd(head, 3);
    InsertAtEnd(head, 2);
    InsertAtEnd(head, 1);

    cout << "\nLinked List Contenet:\n";
    PrintList(head);
    


    system("pause>0");
    return 0;
}