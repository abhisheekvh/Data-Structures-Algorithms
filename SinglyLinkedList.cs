using System;
using System.Collections.Generic;
namespace QuickSortDemo
{
    public class LinkedListOperation
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }
        public Node head;
        public void SortedInsert(int data)
        {
            Node newNode = new Node(data, null);
            Node curr = head;
            if (head == null || head.data > data)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            else
            {
                while (curr.next != null && curr.next.data <= data)
                {
                    curr = curr.next;
                }
                newNode.next = curr.next;
                curr.next = newNode;

            }
        }
        public bool search(int val)
        {
            Node curr = head;
            if (head.data == val)
                return true;
            while (curr != null)
            {
                if (curr.data == val)
                {
                    return true;
                }
                curr = curr.next;
            }
            return false;
        }
        //Recursive method to find Node value

        public bool RecursiveSearch(int data)
        {
            return SearchRecursive(head, data);
        }
        public bool SearchRecursive(Node curr, int data)
        {
            if (curr.next == null)
                return false;

            if (curr.data == data)
                return true;

            return SearchRecursive(curr = curr.next, data);

        }

        //Delete First Node 
        public void DeleteHead()
        {
            if (head == null)
                return;
            head = head.next;

        }
        //Delete Particulr node 
        public int DeleteNode(int delNode)
        {
            if (head == null)
                return -1;
            if (head.data == delNode)
            {
                int delvalue = head.data;
                head = head.next;
                return delvalue;
            }
            Node curr = head;
            while (curr.next != null && curr.next.data != delNode)
            {
                curr = curr.next;
            }
            if (curr.next == null)
            {
                return -1;
            }
            int val = curr.next.data;
            curr.next = curr.next.next;
            return val;
        }
        //Delete the nodes which are present in array ( continuous nodes )
        public void DeleteMoreThanOne(int[] arr)
        {
            Node curr = head;
            int i = 0;
            bool visited = false;
            while (curr.next != null)
            {
                Node outer = curr;
                while (i < arr.Length && outer.next.data == arr[i])
                {
                    i++;
                    outer = outer.next;
                    visited = true;
                }
                if (visited)
                {
                    curr.next = outer.next;
                    curr = curr.next;
                }
                else
                    curr = curr.next;
            }

        }
        public void PairSwap()
        {
            Node curr = head;
            while (curr != null && curr.next != null)
            {
                int temp = curr.data;
                curr.data = curr.next.data;
                curr.next.data = temp;
                curr = curr.next.next;
            }
        }
        public void RemoveNthNodeFromEnd(int position)
        {
            Node curr = head;
            int count = 0;
            int pos = 0;
            while (curr.next != null)
            {
                count++;
                curr = curr.next;
            }
            pos = count - position;
            count = 0;
            curr = head;
            while (curr.next != null && count != pos)
            {
                curr = curr.next;
                count++;
            }
            curr.next = curr.next.next;

        }
        public void FindMiddleNode()
        {
            Node slow = head;
            Node fast = head;
            Node curr = head;
           if(head != null)
            {
                while(fast!=null && fast.next!=null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                }
            }
            Console.WriteLine(slow.data);

        }

        //Remove duplicate nodes with O(n) time complexity
        public void RemoDuplicateNodes()
        {
            HashSet<int> hs = new HashSet<int>();
            Node curr = head;
            Node prev = null;
            while (curr != null)
            {
                if (hs.Contains(curr.data))
                {
                    prev.next = curr.next;
                }
                else
                {
                    hs.Add(curr.data);
                    prev = curr;
                }
                curr = curr.next;
            }
        }
        //Change nodes at k position
        public void ChangeNodes(int k)
        {
            int t = k;
            Node curr = head;
            int cnt = 1;
            int i = 0;
            while (curr.next != null)
            {
                Node outer = curr;
                while (outer.next != null && cnt != k)
                {
                    outer = outer.next;
                    cnt++;
                }
                int temp = outer.data;
                outer.data = curr.data;
                curr.data = temp;
                while (curr.next != null && i != k)
                {
                    curr = curr.next;
                    i++;
                }
                k = t + k;
                cnt++;
            }
        }
        //Reverse linked list using recursive method
        public Node Reverse(Node head, Node store)
        {
            Node ret;
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                head.next = store;
                return head;
            }
            ret = Reverse(head.next, head);
            head.next = store;
            return ret;
        }
        public void ReverseList()
        {
            Node store = null;
            Node curr = Reverse(head, store);
            while (curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.next;
            }

        }
        //Reverse Linked list using loop
        public void ReverUsingLoop()
        {
            Node prev = null;
            Node next = null;
            Node curr = head;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;

            }

        }
        //Linked list partition based on k value

        public void partion(int k)
        {                                     
            int[] arr = new int[] { 1,4,3,2,5,2 };
            int i = 0;        //    2,2,3,6,12,4,7
            int j = arr.Length - 1;
            while (i < j)
            {
                while (arr[i] < k && i < arr.Length)
                {
                    i++;
                }
                while (arr[j] >= k && j > 0)
                {
                    j--;
                }
                if (i < j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                i++;
                j--;
            }
            for(int l=0;l<arr.Length;l++)
            {
                Console.Write(arr[l] +" ");
            }

        }

        //Ceck wheather the list is palindrome or not using stack
        public bool Palindrome()
        {
            Stack<int> st = new Stack<int>();
            Node curr = head;
            Node validate = head;
            while (curr != null)
            {
                st.Push(curr.data);
                curr = curr.next;
            }
            while (validate.next != null)
            {
                if (validate.data != st.Peek())
                {
                    return false;
                }
                st.Pop();
                validate = validate.next;
            }
            if (validate.next == null)
            {
                return true;
            }
            return false;
        }
        //Ceck wheather the list is palindrome or not using Copy method
        public bool CheckPalindrome()
        {
            Node tempNode = null;
            Node tempNode2 = null;
            Node curr = head;
            while(curr != null)
            {
                tempNode2 = new Node(curr.data, tempNode);
                curr = curr.next;
                tempNode = tempNode2;
            }
            curr = head;
            //LinkedListOperation ll2 = new LinkedListOperation();
            //ll2.head = tempNode;
            while(curr!=null && tempNode != null)
            {
                if(curr.data==tempNode.data)
                {
                    curr = curr.next;
                    tempNode = tempNode.next;
                }
                else
                {
                    return false;
                }
            }
            if(curr.next==null && tempNode.next==null)
            {
                return true;
            }
            return false;
        }
       
        public bool LoopDetect()
        {
            Node fast = head;
            Node slow = head;
             if(head != null)
            {
                while(fast != null && fast.next!=null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                    if (fast == slow)
                    {
                        return true;
                    }
                    
                }
               
            }
            return false;
        }

        public void print()
        {
            Node curr = head;
            while (curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.next;
            }
        }

    }
    class Example
    {

        static void Main(string[] args)
        {
            LinkedListOperation l = new LinkedListOperation();
            l.SortedInsert(1);
            l.SortedInsert(2);
            l.SortedInsert(3);
            l.SortedInsert(4);
            l.SortedInsert(5);
            l.SortedInsert(6);
            l.SortedInsert(7);
            l.SortedInsert(8);
            l.print();
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Searching value in node");
            Console.WriteLine();
            if (l.search(20))
                Console.Write("Present");
            else
                Console.Write("Not Present");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Recursively search Number");
            Console.WriteLine();
            if (l.RecursiveSearch(3))

                Console.Write("Present");
            else
                Console.Write("Not Present");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Delete Head Node //Commented");
            Console.WriteLine();
            //l.DeleteHead();
            l.print();
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Delete Particular Node //commented");
            Console.WriteLine();
            // Console.WriteLine("Deleted Node is : " + l.DeleteNode(3));
            Console.WriteLine();
            l.print();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Delete the nodes which are present in array ( continuous nodes ) : 30,40,50 //Commented");
            int[] arr = new int[] { 30, 40, 50 };
            // l.DeleteMoreThanOne(arr);
            Console.WriteLine();
            l.print();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Swap the pair nodes //Commented");
            //l.PairSwap();
            Console.WriteLine();
            l.print();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("Remove nth node from end //Commented");
            // l.RemoveNthNodeFromEnd(3);
            Console.WriteLine();
            l.print();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Remove All duplicate nodes //Commented");
            // l.RemoDuplicateNodes();
            Console.WriteLine();
            l.print();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Change node at k place");
            l.ChangeNodes(4);
            Console.WriteLine();
            l.print();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Reverse Linked list using loop");
            Console.WriteLine();
            //l.ReverUsingLoop();
            //l.print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Reverse Linked list using recursion");
            Console.WriteLine();
           // l.ReverseList();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Finding middle element");
            Console.WriteLine();
            l.FindMiddleNode();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Copy list to another list in reverse order");
            Console.WriteLine();
          //  l.CopyListInReverse();
            Console.WriteLine();

            Console.Read();
        }
    }
}