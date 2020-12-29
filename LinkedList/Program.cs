using System;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}

class Solution
{

    public static Node Insert(Node head, int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return head;
        }
        else
        {           
            Node currentLast = head;
            // traverse the linkedlist till the last member
            while (currentLast.next != null)
            {
                currentLast = currentLast.next;
            }

            currentLast.next = newNode;
            return head;
        }
        
        
    }

    public static void Display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    static void Main(String[] args)
    {
        var input = BasicApp.Program.ReadFile();

        Node head = null;
        int T = Int32.Parse(input.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(input.ReadLine());
            head = Insert(head, data);
        }
        Display(head);
    }
}

