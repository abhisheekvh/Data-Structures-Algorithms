using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinkedListOperations
{
    public class LinkedList
    {
        public node head;
        public class node
        {
            internal int value;
            internal node next;
            public node(int value, node n)
            {
                this.value = value;
                next = n;
            }
        }
        private int count = 0;
        public void AddHead(int val)
        {
            head = new node(val, head);
            count++;

        }
        public void AddEnd(int val)
        {
            node newNode = new node(val, null);
            node curr = head;
            if (head == null)
            {
                head = newNode;
                return;
            }
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }
        public void SortedInsert(int val)
        {
            node newNode = new node(val, null);
            node curr = head;
            if (curr == null || curr.value > val)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            while (curr.next != null && curr.next.value < val)
            {
                curr = curr.next;
            }
            newNode.next = curr.next;
            curr.next = newNode;
        }
        public void Print()
        {
            node temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }

        }

        public int DeleteHead()
        {
            try
            {
                if (head == null)
                {
                    throw new InvalidOperationException("Not possible to delete the head");
                }
                int val = head.value;
                head = head.next;
                count--;
                return val;

            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int deleteNode(int val)
        {
            node tmp = head;
            if (tmp == null)
                return -1;
            if (tmp.value == val)
            {
                int deletednode = head.value;
                head = head.next;
                count--;
                return deletednode;

            }
            while (tmp.next != null)
            {
                if (tmp.next.value == val)
                {
                    int dVal = tmp.next.value;
                    tmp.next = tmp.next.next;
                    count--;
                    return dVal;
                }
                tmp = tmp.next;
            }
            return -1;
        }
        public void DeleteAllnodes(int val)
        {
            if (head == null)
                return;
            node curr = head;
            node nextNode;
            while (curr != null && curr.value == val)
            {
                head = curr.next;
                curr = head;
            }
            while (curr != null)
            {
                nextNode = curr.next;
                if (nextNode != null && nextNode.value == val)
                {
                    curr.next = nextNode.next;
                }
                else
                {
                    curr = nextNode;
                }
            }
        }
        public void ReverseLinkedlist()
        {
            node curr = head;
            node prev = null;
            node next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }
        public node RecursiveReverse(node currentNode, node nextNode)
        {
            node ret;
            if (currentNode == null)
                return null;
            if (currentNode.next == null)
            {
                currentNode.next = nextNode;
                return currentNode;
            }
            ret = RecursiveReverse(currentNode.next, currentNode);
            currentNode.next = nextNode;
            return ret;
        }
        public void ReverseRecu()
        {
            head = RecursiveReverse(head, null);
        }

        private node Reverse(node current, node nextnode)
        {
            node ret;
            if (current == null)
                return null;
            if (current.next == null)
            {
                current.next = nextnode;
                return current;
            }
            ret = Reverse(current.next, current);
            current.next = nextnode;
            return ret;

        }

        public void Reciver()
        {
            head = Reverse(head, null);
        }
        public void RemoveDuplicateFromSorted()
        {
            node current = head;
            if (current == null)
                return;
            while (current != null)
            {
                if (current.next != null && current.value == current.next.value)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
        }

        //-------------------------------------------------------------------------


        //using brute force approach
        public bool DublicateCheck()
        {
            node tmp = head;
            node nxt = head;
            while (tmp != null)
            {
                int val = tmp.value;
                while (nxt.next != null && (val != nxt.next.value))
                    nxt = nxt.next;
                if (nxt.next != null && val == nxt.next.value)
                    return true;
                if (nxt.next == null)
                {
                    nxt = tmp.next;
                    tmp = tmp.next;
                }
            }
            return false;
        }
        //using Recursive approach
        
        public int[] RemoveDuplicate()
        {
            node ptr1 = null, ptr2 = null;//, dup = null;
            int[] store = new int[5];
            int i = 0;
            ptr1 = head;
            while(ptr1 != null && ptr1.next!=null)
            {
                ptr2 = ptr1;
                while(ptr2.next != null)
                {
                    if(ptr1.value ==ptr2.next.value)
                    {
                        //dup = ptr2.next;
                        store[i++] = ptr2.next.value;
                        ptr2.next = ptr2.next.next;
                    }
                    else
                    {
                        ptr2 = ptr2.next;
                    }
                }
                ptr1 = ptr1.next;
            }
            return store;
        }
        //Remove duplicate using hash set

        //Efficient one
        public void RemoveDuplicateUsingHash()
        {
            HashSet<int> hs = new HashSet<int>();//HasSet will accepts only unique values
            node current = head;
            node prev = null;
            while(current != null)
            {
                int val = current.value;
                if(hs.Contains(val))
                {
                    prev.next = current.next;
                }
                else
                {
                    hs.Add(val);
                    prev = current;
                }
                current = current.next;
            }
        }
        //Error code need to be fixed
        public void OddEven()
        {
            node curr = null, ptr1 = null, ptr2 = null, nxt = null;
            ptr1 = head;
            bool visited = false;
            while (ptr1 != null)
            {
                ptr2 = ptr1;
                while (ptr2 != null)
                {
                    ptr2.next = ptr2.next.next;
                    //ptr2 = ptr2.next.next;
                    if (ptr2.next == null && visited == false)
                    {
                        curr = ptr2;
                        ptr2 = null;
                        visited = true;
                    }
                    if (visited)
                    {
                        nxt = ptr2;
                    }
                }
                ptr1 = ptr1.next;
            }

            while (nxt != null)
            {
                curr.next.value = nxt.value;
                nxt = nxt.next;
            }
        }


        //using recursive method
       public bool CompareLinkedList(node head1,node head2)
        {
            if(head1==null && head2==null)
            {
                return true;
            }
            if(head1 == null ||head == null ||(head1.value !=head2.value))
            {
                return false;
            }
            return CompareLinkedList(head1.next, head2.next);
        }
        //using iterative method
        public bool CompareLinkedListIterative(node head1,node head2)
        {
            if(head1 == null && head2== null)
            {
                return true;
            }
           
            while(head1 != null && head2 != null)
            {
                if(head1.value != head2.value )
                {
                    return false;
                }
                head1 = head1.next;
                head2 = head2.next;
                if (head1.next == null && head2.next == null)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
    public class Driver
    {
        public static void Main()
        {
            LinkedList l = new LinkedList();
            LinkedList ll = new LinkedList();
            //l.SortedInsert(1);
            //l.SortedInsert(2);
            //l.SortedInsert(1);
            //l.SortedInsert(4);
            //l.SortedInsert(1);
            l.AddEnd(1);
            l.AddEnd(2);
            l.AddEnd(3);
            l.AddEnd(4);
            l.AddEnd(5);

            ll.AddEnd(1);
            ll.AddEnd(8);
            ll.AddEnd(3);
            ll.AddEnd(4);
            ll.AddEnd(5);
            //l.Print();
            Console.WriteLine();
            //if(l.DublicateCheck())
            //    Console.WriteLine("Duplicate found!");
            //else
            //    Console.WriteLine("Duplicate not found");
            Console.WriteLine();
            //Console.WriteLine("Deleted head value is -> "+l.DeleteHead());
            Console.WriteLine();
            //int val = l.deleteNode(31);
            //if (val != -1)
            //    Console.WriteLine("Deleted head value is -> " + val);
            //else
            //    Console.WriteLine("value is not found");
            // l.DeleteAllnodes(34);
            // l.ReverseLinkedlist();
            //l.Reciver();
            // l.RemoveDuplicateFromSorted();

            // var duplicates=l.RemoveDuplicate();
            //foreach(var val in duplicates)
            //{
            //    if(val != 0)
            //    Console.Write(val + "  ");
            //}
            //l.RemoveDuplicateUsingHash();
            //l.OddEven();

            if(l.CompareLinkedListIterative(l.head, ll.head))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");
            Console.WriteLine();
            //l.Print();
            // l.Print();
            Console.Read();
        }

    }

}
