﻿using System;
using System.Collections.Generic;
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
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
