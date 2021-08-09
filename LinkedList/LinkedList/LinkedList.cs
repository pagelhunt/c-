using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        //private field
        private Node head; //ref to first node in list
        private int count; //current count of list

 

        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }

        public object this[int index]
        {
            get { return this.Get(index); }
        }


        //constructor
        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public object Add(int index, object o) // add object to specified index
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if(index > this.count)
                index = this.count;

            Node current = this.head;

            if(this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for(int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node(o, current.Next);
            }

            this.count++;
            return o;
        }

        public object Add(object o) // add object to end of list
        {
            return this.Add(this.count, o);
        }

        public object Remove(int index) //removes object at index
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty || index == 0)
                return null;

            if (index >= this.count)
                index = this.count - 1;

            Node current = this.head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                    result = current.Next.Data;

                    current.Next = current.Next.Next;
                
            }

            this.count--;

            return result;
        }

        public void Clear() //clear list
        {
            this.head = null;
            this.count = 0;
        }

        public int IndexOf(object o) //gets index of object, if object not in list return -1
        {
            Node current = this.head;

            for (int i = 0; i < this.count; i++)
            {
                if (current.Data == o)
                {
                    return i;
                }

                current = current.Next;
            }

            return -1;
        }

        public bool Contains(object o) //check is object is in list
        {
            return this.IndexOf(o) != -1;
        }

        public object Get(int index) //gets item at specified index
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty)
                return null;
            
            if (index >= this.count)
                index = this.count - 1;

            Node current = this.head;

            for(int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }
    }
}
