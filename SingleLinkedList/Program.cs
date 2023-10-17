using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
     class Node
    {
        public int info;
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }


    class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }



        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            p = start;
            Console.Write("List: ");
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }


        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("number of nodes in the list is " + n);
        }

        public bool search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + "it s not in the list");
                return false;
            }
            else
            {
                Console.WriteLine(x+  "is at position" + position);
                return true;
            }

        }

        public void CreateList()
        {
            int i, n, data;
            Console.WriteLine("Enter the number of Nodes");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            Console.WriteLine("Enter the element to be inserted");
            data = Convert.ToInt32(Console.ReadLine());
            InsertAtEnd(data); // Insert the first element outside the loop

            for (i = 1; i < n; i++) // Start the loop from 1 as the first element is already added
            {
                Console.WriteLine("Enter the element to be inserted");
                data = Convert.ToInt32(Console.ReadLine());

                InsertAtEnd(data);
            }
        }


        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if (start == null)
            {
                start = newNode;
            }
            else
            {
                newNode.link = start;
                start = newNode;
            }
        }


        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (start == null)
            {
                start = newNode;
            }
            else
            {
                Node p = start;
                while (p.link != null)
                {
                    p = p.link;
                }
                p.link = newNode;
            }
        }

    }



    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();


            while (true)
            {
                Console.WriteLine("1: display List");
                Console.WriteLine("2: Count the Number of Nodes");
                Console.WriteLine("3: Search for an element");
                Console.WriteLine("4:  Insert a node");



                Console.WriteLine("enter your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 5)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("Invalid -- pls select valid choice");
                    Console.WriteLine("*****************");

                }

                     

                switch (choice)
                {
                    case 1:
                        list.DisplayList(); break;  
                    case 2: 
                        list.CountNodes(); break;
                    case 3:
                        Console.WriteLine("enter the element you want to search");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.search(data) ; break;
                    case 4:
                        Console.WriteLine("Enter the data into the new node");
                        int x = Convert.ToInt32(Console.ReadLine());    
                        Console.WriteLine("select a number");
                        Console.WriteLine("1--- for insert data at end of list ");
                        Console.WriteLine("2--- for insert data at begnning of list");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        if (ch >= 3)
                        {
                            Console.WriteLine("*****************");
                            Console.WriteLine("Invalid -- pls select valid number");
                            Console.WriteLine("*****************");

                        }

                        switch (ch)
                        {
                            case 1:
                                list.InsertAtEnd(x); break;
                            case 2:
                                list.InsertAtBeginning(x); break;
                            default: break;
                        }
                        break;
                    default: break;
                }
                     
            }

             
        }

    }
    
}
 