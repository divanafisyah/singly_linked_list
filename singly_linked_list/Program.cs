﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    //each Node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }

    class List
    {
        Node START;
        public List()
        { 
            START = null;
        }
        public void addNote()
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student:");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll number of the student:");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            //if the node to be inserted is the first node
            if(START == null || rollNo <= START.rollNumber)
            {
                if((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (rollNo >= current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                previous.next = newnode;
            }
            previous.next = current;
            previous.next = newnode;
        }
        public bool delNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
                if (current == START)
                    START = START.next;
            return true;
        }

        public bool Search(int rollNo, ref  Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while((current != null)&&(rollNo != current.rollNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void Traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nThe records in the list are:");
            else
            {
                Console.WriteLine("\nThe records in the list are:");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next) ;
                Console.Write(currentNode.rollNumber + "" + currentNode.name + "\n");
                Console.WriteLine();
            }
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
        List obj = new List();
            while(true)
            {
                try
                {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Add a record to the list");
                Console.WriteLine("2. Delete a record to the list");
                Console.WriteLine("3. View all the records in the list");
                Console.WriteLine("4. Search for a record in the list");
                Console.WriteLine("5. EXIT");
            }
        }
        }
    }
