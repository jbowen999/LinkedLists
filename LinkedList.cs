﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        public Node? First { get; set; }

        public void InsertFirst(int data)
        {
            // Create the node
            Node newNode = new Node();
            // Put the data in the node
            newNode.Data = data;
            // Put the old node in next
            newNode.Next = First;
            // Make the first new node
            First = newNode;
        }
        public Node DeleteFirst()
        {
            // Assign the temporaty variable
            Node temp = First;
            //Assign the next  dead
            First = First.Next;
            return temp;

        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through the list...");
            Node current = First;
            while(current != null)
            {
                current.DisplayNode();
                current = current.Next;

            }
        }
        public  void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}
