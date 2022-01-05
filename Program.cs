using System;

namespace LinkedList
{
   public class Linkedlist
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
                    head = newNode;
                while(curr != null)
                {
                    curr = curr.next;
                }
                curr.next = newNode;
         }
        public void SortedInsert(int val)
        {
            node newNode = new node(val, null);
            node curr = head;
            if(curr == null || curr.value > val)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            while(curr != null && curr.next.value<val)
            {
                curr = curr.next;
            }
            newNode.next = curr.next;
            curr.next = newNode;
        }
         public void Print()
         {
               node temp = head;
               while(temp != null)
               {
                   Console.Write(temp.value + " ");
                   temp = temp.next;
               }

         }

        public  int DeleteHead()
        {
            try
            {
                if(head==null)
                {
                    throw new InvalidOperationException("Not possible to delete the head");
                }
                int val = head.value;
                head = head.next;
                count--;
                return val;

            }catch(Exception ex)
            {
                return -1;
            }
        }

    }
    public class Driver
    {
        public static void Main()
        {

            Linkedlist l = new Linkedlist();

            
            l.SortedInsert(36);
            l.SortedInsert(34);
            l.SortedInsert(35);
            l.Print();
            Console.WriteLine();
            Console.WriteLine("Deleted head value is -> "+l.DeleteHead());
            Console.WriteLine();
            l.Print();
            Console.Read();
        }

    }
  
}
