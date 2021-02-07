using System;

namespace ThreeStackIntoSingleArray
{
    class Program
    {
        public class Stack
        {
            public int[] array; 
            public int[] top; 
            public int[] next; 

            public int n, k;
            public int free; 

            public Stack(int k, int n)
            {
                array = new int[n];
                top = new int[k];
                next = new int[n];

                for (int i = 0; i < k; i++)
                {
                    top[i] = -1;
                }

                free = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    next[i] = i + 1;
                }
                next[n - 1] = -1;  
            }

            public virtual bool Full
            {
                get
                {
                    return (free == -1);
                }
            }

            public virtual void push(int item, int sn)
            {
                if (Full)
                {
                    Console.WriteLine("Overflow");
                    return;
                }

                int i = free;

                free = next[i];

                next[i] = top[sn];
                top[sn] = i;

                array[i] = item;
            }

            public virtual int pop(int sn)
            {
                if (isEmpty(sn))
                {
                    Console.WriteLine("Underflow");
                    return int.MaxValue;
                }

                int i = top[sn];

                top[sn] = next[i]; 

                next[i] = free;
                free = i;

                return array[i];
            }

            public virtual bool isEmpty(int sn)
            {
                return (top[sn] == -1);
            }

        }

        public static void Main(string[] args)
        {
            

            Stack s = new Stack(3, 10);

            s.push(15, 2);
            s.push(45, 2);

            s.push(17, 1);
            s.push(49, 1);
            s.push(39, 1);

            s.push(11, 0);
            s.push(9, 0);
            s.push(7, 0);

            s.pop(2);
            s.pop(1);
            s.pop(0);
        }
    }
}
