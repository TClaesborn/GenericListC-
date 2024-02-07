using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew
{
    internal class List<T> // T är en input type.
    {
        public Node<T> head { get; private set; }

        public List()
        {
            head = null;
        }
            
        public void RemoveFirst()
        {
            head = head.next;
        }

        public bool RemoveValue(T data)
        { return true; }

        public void AddAtIndex(T data, int index)
        { }


        public void Add(T data)
        {
            if (head == null)
                head = new Node<T>(data); //Kollar och sätter första värdet
            else
            {
                Node<T> current = head; //Om första värde finns så spara en ref till det
                while(current.next != null) //Kolla om current har ett nästa värde.
                {
                    current = current.next; //Flyttar ref till nästa värde
                }
                current.next = new Node<T>(data); //Skapar ny nod vid slutet av listan.
            }
        }
        public bool Find(T data)
        {
            Node<T> current = head;
            while(current != null)
            {
                if (current.value.Equals(data))
                    return true;
                current = current.next;
            }
            return false;
        }

        public void PrintAll()
        {
            Node<T> current = head;
            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }

    internal class Node<T>
    {
        public T value { get; set; }
        public Node<T> next { get; set; }

        public Node(T data)
        {
            this.value = data;
            this.next = null;
        }
    }
}
